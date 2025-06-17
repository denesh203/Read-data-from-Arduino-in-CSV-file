using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Collections.Concurrent;
using System.Data;

namespace ArduinoRead
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private ConcurrentQueue<string> serialQueue = new ConcurrentQueue<string>();
        private Timer uiUpdateTimer;
        private int serialNumber = 1;
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeSerialPort();
            InitializeTimer();
        }

        private void InitializeSerialPort()
        {
            serialPort = new SerialPort
            {
                PortName = "COM9", // ⚠️ Adjust to your port
                BaudRate = 115200,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None
            };
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void InitializeTimer()
        {
            uiUpdateTimer = new Timer
            {
                Interval = 100 // ms
            };
            uiUpdateTimer.Tick += UiUpdateTimer_Tick;
            uiUpdateTimer.Start();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataTable = new DataTable(); // Create new table

            for (int i = 0; i <= 23; i++)
            {
                string name = $"C{i}";
                string header;

                if (i == 0)
                    header = "SN";
                else if (i == 1)
                    header = "Koki";
                else if (i == 2)
                    header = "CMD";
                else if (i == 3)
                    header = "[hPa]LO";
                else if (i == 4)
                    header = "[hPa]HI";
                else if (i == 5)
                    header = "Hook1:RFID";
                else if (i == 6)
                    header = "Hook2:RFID";
                else if (i == 7)
                    header = "Temp1";
                else if (i == 8)
                    header = "Temp2";
                else if (i == 9)
                    header = "Hum[％]1";
                else if (i == 10)
                    header = "HUM[％]2";
                else if (i == 11)
                    header = "Hook1:[X]";
                else if (i == 12)
                    header = "Hook1:[Y]";
                else if (i == 13)
                    header = "Hook1:[Z]";
                else if (i == 14)
                    header = "Not used";
                else if (i == 15)
                    header = "Hook2:[X]";
                else if (i == 16)
                    header = "Hook2:[Y]";
                else if (i == 17)
                    header = "Hook2:[Z]";
                else if (i == 18)
                    header = "Not used1";
                else if (i == 19)
                    header = "[hPa]3";
                else if (i == 20)
                    header = "Temp3";
                else if (i == 21)
                    header = "Hum3";
                else if (i == 22)
                    header = "GPS(N)";
                else if (i == 23)
                    header = "GPS(E)";
                else
                    header = $"C{i}";

                dataGridView1.Columns.Add(name, header);
                dataTable.Columns.Add(header); // Use header as column name
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    button1.BackColor = Color.Green;
                    button3.BackColor = Color.Gray;
                }
                else
                {
                    MessageBox.Show("シリアル通信されています.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                button1.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                button1.BackColor = Color.Gray;
                button3.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = $"ArduinoData_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder csvContent = new StringBuilder();
                        var headers = dataGridView1.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText);
                        csvContent.AppendLine(string.Join(",", headers));

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cells = row.Cells.Cast<DataGridViewCell>()
                                                    .Select(cell => EscapeCsvValue(cell.Value?.ToString() ?? ""));
                                csvContent.AppendLine(string.Join(",", cells));
                            }
                        }

                        File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());
                        MessageBox.Show($"Data saved successfully to:\n{saveFileDialog.FileName}",
                                        "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving CSV file:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EscapeCsvValue(string value)
        {
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r"))
            {
                return $"\"{value.Replace("\"", "\"\"")}\"";
            }
            return value;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = serialPort.ReadLine();
                serialQueue.Enqueue(line);
            }
            catch (Exception ex)
            {
                serialQueue.Enqueue("Read error: " + ex.Message);
            }
        }

        private void UiUpdateTimer_Tick(object sender, EventArgs e)
        {
            while (serialQueue.TryDequeue(out string data))
            {
                string cleaned = CleanReceivedData(data);

                if (!string.IsNullOrWhiteSpace(cleaned) && !cleaned.Trim().Equals("00") &&
                    !cleaned.Trim().Equals("mode-0") && !cleaned.Trim().Equals("mode-1"))
                {
                    AppendToRichTextBox(cleaned);
                    UpdateDataGridView(cleaned);
                }
            }
        }

        private string CleanReceivedData(string input)
        {
            try
            {
                string cleaned = input.Replace("RcvData koki-: ", "")
                                      .Replace("cmd:", "")
                                      .Replace("data ", "");

                int oyakiIndex = cleaned.IndexOf("OyakiData : ");
                if (oyakiIndex < 0) return input;

                string firstPart = cleaned.Substring(0, oyakiIndex).Trim();
                string secondPart = cleaned.Substring(oyakiIndex + "OyakiData : ".Length).Trim();
                string result = $"{firstPart},{secondPart}";

                return Regex.Replace(result, @"\s*,\s*", ",");
            }
            catch
            {
                return input;
            }
        }

        private void UpdateDataGridView(string dataRow)
        {
            try
            {
                string[] values = dataRow.Split(',');

                if (values.Length == 23)
                {
                    // Prepend serial number
                    string[] newRow = new string[24];
                    newRow[0] = serialNumber.ToString();
                    for (int i = 0; i < 23; i++)
                    {
                        newRow[i + 1] = values[i];
                    }

                    dataGridView1.Rows.Add(newRow);
                    serialNumber++;

                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                }
                else
                {
                    AppendToRichTextBox($"Invalid data length: {values.Length} (expected 23)");
                }
            }
            catch (Exception ex)
            {
                AppendToRichTextBox("Grid update error: " + ex.Message);
            }
        }

        private void AppendToRichTextBox(string text)
        {
            richTextBox1.AppendText(text + Environment.NewLine);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }
    }
}
