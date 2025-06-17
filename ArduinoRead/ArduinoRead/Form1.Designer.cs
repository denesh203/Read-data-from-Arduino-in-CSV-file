using System.Windows.Forms;

namespace ArduinoRead
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1601, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 789);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(9, 294);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 131);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Save";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(4, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "CSV Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(9, 185);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Disconnect";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c0,
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8,
            this.c9,
            this.c10,
            this.c11,
            this.c12,
            this.c13,
            this.c14,
            this.c15,
            this.c16,
            this.c17,
            this.c18,
            this.c19,
            this.c20,
            this.c21,
            this.c22,
            this.c23});
            this.dataGridView1.Location = new System.Drawing.Point(16, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1587, 738);
            this.dataGridView1.TabIndex = 1;
            // 
            // c0
            // 
            this.c0.HeaderText = "SN";
            this.c0.MinimumWidth = 6;
            this.c0.Name = "c0";
            this.c0.ReadOnly = true;
            // 
            // c1
            // 
            this.c1.HeaderText = "C1";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            // 
            // c2
            // 
            this.c2.HeaderText = "c2";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // c3
            // 
            this.c3.HeaderText = "c3";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            // 
            // c4
            // 
            this.c4.HeaderText = "c4";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            // 
            // c5
            // 
            this.c5.HeaderText = "c5";
            this.c5.MinimumWidth = 6;
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            // 
            // c6
            // 
            this.c6.HeaderText = "c6";
            this.c6.MinimumWidth = 6;
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            // 
            // c7
            // 
            this.c7.HeaderText = "c7";
            this.c7.MinimumWidth = 6;
            this.c7.Name = "c7";
            this.c7.ReadOnly = true;
            // 
            // c8
            // 
            this.c8.HeaderText = "c8";
            this.c8.MinimumWidth = 6;
            this.c8.Name = "c8";
            this.c8.ReadOnly = true;
            // 
            // c9
            // 
            this.c9.HeaderText = "c9";
            this.c9.MinimumWidth = 6;
            this.c9.Name = "c9";
            this.c9.ReadOnly = true;
            // 
            // c10
            // 
            this.c10.HeaderText = "c10";
            this.c10.MinimumWidth = 6;
            this.c10.Name = "c10";
            this.c10.ReadOnly = true;
            // 
            // c11
            // 
            this.c11.HeaderText = "c11";
            this.c11.MinimumWidth = 6;
            this.c11.Name = "c11";
            this.c11.ReadOnly = true;
            // 
            // c12
            // 
            this.c12.HeaderText = "c12";
            this.c12.MinimumWidth = 6;
            this.c12.Name = "c12";
            this.c12.ReadOnly = true;
            // 
            // c13
            // 
            this.c13.HeaderText = "c13";
            this.c13.MinimumWidth = 6;
            this.c13.Name = "c13";
            this.c13.ReadOnly = true;
            // 
            // c14
            // 
            this.c14.HeaderText = "c14";
            this.c14.MinimumWidth = 6;
            this.c14.Name = "c14";
            this.c14.ReadOnly = true;
            // 
            // c15
            // 
            this.c15.HeaderText = "c15";
            this.c15.MinimumWidth = 6;
            this.c15.Name = "c15";
            this.c15.ReadOnly = true;
            // 
            // c16
            // 
            this.c16.HeaderText = "c16";
            this.c16.MinimumWidth = 6;
            this.c16.Name = "c16";
            this.c16.ReadOnly = true;
            // 
            // c17
            // 
            this.c17.HeaderText = "c17";
            this.c17.MinimumWidth = 6;
            this.c17.Name = "c17";
            this.c17.ReadOnly = true;
            // 
            // c18
            // 
            this.c18.HeaderText = "c18";
            this.c18.MinimumWidth = 6;
            this.c18.Name = "c18";
            this.c18.ReadOnly = true;
            // 
            // c19
            // 
            this.c19.HeaderText = "c19";
            this.c19.MinimumWidth = 6;
            this.c19.Name = "c19";
            this.c19.ReadOnly = true;
            // 
            // c20
            // 
            this.c20.HeaderText = "c20";
            this.c20.MinimumWidth = 6;
            this.c20.Name = "c20";
            this.c20.ReadOnly = true;
            // 
            // c21
            // 
            this.c21.HeaderText = "c21";
            this.c21.MinimumWidth = 6;
            this.c21.Name = "c21";
            this.c21.ReadOnly = true;
            // 
            // c22
            // 
            this.c22.HeaderText = "c22";
            this.c22.MinimumWidth = 6;
            this.c22.Name = "c22";
            this.c22.ReadOnly = true;
            // 
            // c23
            // 
            this.c23.HeaderText = "c23";
            this.c23.MinimumWidth = 6;
            this.c23.Name = "c23";
            this.c23.ReadOnly = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(108, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1415, 40);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1821, 795);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Arduino Data Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private SaveFileDialog saveFileDialog;
        private Panel panel2;
        private Label label1;
        private DataGridViewTextBoxColumn c0;
        private DataGridViewTextBoxColumn c1;
        private DataGridViewTextBoxColumn c2;
        private DataGridViewTextBoxColumn c3;
        private DataGridViewTextBoxColumn c4;
        private DataGridViewTextBoxColumn c5;
        private DataGridViewTextBoxColumn c6;
        private DataGridViewTextBoxColumn c7;
        private DataGridViewTextBoxColumn c8;
        private DataGridViewTextBoxColumn c9;
        private DataGridViewTextBoxColumn c10;
        private DataGridViewTextBoxColumn c11;
        private DataGridViewTextBoxColumn c12;
        private DataGridViewTextBoxColumn c13;
        private DataGridViewTextBoxColumn c14;
        private DataGridViewTextBoxColumn c15;
        private DataGridViewTextBoxColumn c16;
        private DataGridViewTextBoxColumn c17;
        private DataGridViewTextBoxColumn c18;
        private DataGridViewTextBoxColumn c19;
        private DataGridViewTextBoxColumn c20;
        private DataGridViewTextBoxColumn c21;
        private DataGridViewTextBoxColumn c22;
        private DataGridViewTextBoxColumn c23;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}
