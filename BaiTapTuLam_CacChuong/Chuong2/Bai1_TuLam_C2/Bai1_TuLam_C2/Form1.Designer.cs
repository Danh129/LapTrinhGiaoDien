namespace Bai1_TuLam_C2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert1 = new System.Windows.Forms.Button();
            this.txtAsciiInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConvert2 = new System.Windows.Forms.Button();
            this.txtCharInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCharResult = new System.Windows.Forms.Label();
            this.lblAsciiResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "                 CHUYỂN MÃ ASCII              \r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblCharResult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnConvert1);
            this.groupBox1.Controls.Add(this.txtAsciiInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 478);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyên mã ASCII sang ký tự";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả:";
            // 
            // btnConvert1
            // 
            this.btnConvert1.Location = new System.Drawing.Point(247, 254);
            this.btnConvert1.Name = "btnConvert1";
            this.btnConvert1.Size = new System.Drawing.Size(122, 34);
            this.btnConvert1.TabIndex = 2;
            this.btnConvert1.Text = "Chuyển";
            this.btnConvert1.UseVisualStyleBackColor = true;
            this.btnConvert1.Click += new System.EventHandler(this.btnConvert1_Click);
            // 
            // txtAsciiInput
            // 
            this.txtAsciiInput.Location = new System.Drawing.Point(260, 124);
            this.txtAsciiInput.Name = "txtAsciiInput";
            this.txtAsciiInput.Size = new System.Drawing.Size(100, 34);
            this.txtAsciiInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ASCII";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblAsciiResult);
            this.groupBox2.Controls.Add(this.btnConvert2);
            this.groupBox2.Controls.Add(this.txtCharInput);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(538, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 485);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyển kí tự sang ASCII";
            // 
            // btnConvert2
            // 
            this.btnConvert2.Location = new System.Drawing.Point(251, 241);
            this.btnConvert2.Name = "btnConvert2";
            this.btnConvert2.Size = new System.Drawing.Size(109, 40);
            this.btnConvert2.TabIndex = 4;
            this.btnConvert2.Text = "Chuyển";
            this.btnConvert2.UseVisualStyleBackColor = true;
            this.btnConvert2.Click += new System.EventHandler(this.btnConvert2_Click);
            // 
            // txtCharInput
            // 
            this.txtCharInput.Location = new System.Drawing.Point(251, 122);
            this.txtCharInput.Name = "txtCharInput";
            this.txtCharInput.Size = new System.Drawing.Size(100, 34);
            this.txtCharInput.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kí tự";
            // 
            // lblCharResult
            // 
            this.lblCharResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblCharResult.Location = new System.Drawing.Point(219, 364);
            this.lblCharResult.Name = "lblCharResult";
            this.lblCharResult.Size = new System.Drawing.Size(141, 41);
            this.lblCharResult.TabIndex = 4;
            // 
            // lblAsciiResult
            // 
            this.lblAsciiResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblAsciiResult.Location = new System.Drawing.Point(246, 363);
            this.lblAsciiResult.Name = "lblAsciiResult";
            this.lblAsciiResult.Size = new System.Drawing.Size(141, 41);
            this.lblAsciiResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1714, 863);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bai1_C2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert1;
        private System.Windows.Forms.TextBox txtAsciiInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvert2;
        private System.Windows.Forms.TextBox txtCharInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCharResult;
        private System.Windows.Forms.Label lblAsciiResult;
    }
}

