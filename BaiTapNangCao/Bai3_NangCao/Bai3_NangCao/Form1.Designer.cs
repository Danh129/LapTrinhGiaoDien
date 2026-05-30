namespace Bai3_NangCao
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.btSo1 = new System.Windows.Forms.Button();
            this.btSo2 = new System.Windows.Forms.Button();
            this.btSo3 = new System.Windows.Forms.Button();
            this.btTiepTuc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSo1 = new System.Windows.Forms.Label();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbSo3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.rd4);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Controls.Add(this.rd2);
            this.groupBox1.Controls.Add(this.rd1);
            this.groupBox1.Location = new System.Drawing.Point(65, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn đáp án:";
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.ForeColor = System.Drawing.Color.Navy;
            this.rd1.Location = new System.Drawing.Point(34, 66);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(168, 29);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "3 số bằng nhau";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.ForeColor = System.Drawing.Color.Navy;
            this.rd2.Location = new System.Drawing.Point(36, 119);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(166, 29);
            this.rd2.TabIndex = 1;
            this.rd2.TabStop = true;
            this.rd2.Text = "3 số khác nhau";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.ForeColor = System.Drawing.Color.Navy;
            this.rd3.Location = new System.Drawing.Point(298, 66);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(119, 29);
            this.rd3.TabIndex = 2;
            this.rd3.TabStop = true;
            this.rd3.Text = "3 số gánh";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.ForeColor = System.Drawing.Color.Navy;
            this.rd4.Location = new System.Drawing.Point(298, 119);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(79, 29);
            this.rd4.TabIndex = 3;
            this.rd4.TabStop = true;
            this.rd4.Text = "Khác";
            this.rd4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(749, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐIỂM";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.Navy;
            this.lbDiem.Location = new System.Drawing.Point(789, 222);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(42, 46);
            this.lbDiem.TabIndex = 2;
            this.lbDiem.Text = "0";
            // 
            // btSo1
            // 
            this.btSo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btSo1.ForeColor = System.Drawing.Color.Purple;
            this.btSo1.Location = new System.Drawing.Point(77, 558);
            this.btSo1.Name = "btSo1";
            this.btSo1.Size = new System.Drawing.Size(117, 43);
            this.btSo1.TabIndex = 3;
            this.btSo1.Text = "SỐ 1";
            this.btSo1.UseVisualStyleBackColor = false;
            this.btSo1.Click += new System.EventHandler(this.btSo1_Click);
            // 
            // btSo2
            // 
            this.btSo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btSo2.ForeColor = System.Drawing.Color.Purple;
            this.btSo2.Location = new System.Drawing.Point(289, 561);
            this.btSo2.Name = "btSo2";
            this.btSo2.Size = new System.Drawing.Size(124, 40);
            this.btSo2.TabIndex = 4;
            this.btSo2.Text = "SỐ 2";
            this.btSo2.UseVisualStyleBackColor = false;
            this.btSo2.Click += new System.EventHandler(this.btSo2_Click);
            // 
            // btSo3
            // 
            this.btSo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btSo3.ForeColor = System.Drawing.Color.Purple;
            this.btSo3.Location = new System.Drawing.Point(513, 561);
            this.btSo3.Name = "btSo3";
            this.btSo3.Size = new System.Drawing.Size(112, 44);
            this.btSo3.TabIndex = 5;
            this.btSo3.Text = "SỐ 3";
            this.btSo3.UseVisualStyleBackColor = false;
            this.btSo3.Click += new System.EventHandler(this.btSo3_Click);
            // 
            // btTiepTuc
            // 
            this.btTiepTuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btTiepTuc.ForeColor = System.Drawing.Color.Purple;
            this.btTiepTuc.Location = new System.Drawing.Point(704, 561);
            this.btTiepTuc.Name = "btTiepTuc";
            this.btTiepTuc.Size = new System.Drawing.Size(127, 43);
            this.btTiepTuc.TabIndex = 6;
            this.btTiepTuc.Text = "TIẾP TỤC";
            this.btTiepTuc.UseVisualStyleBackColor = false;
            this.btTiepTuc.Click += new System.EventHandler(this.btTiepTuc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(201, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "CHƯƠNG TRÌNH QUAY SỐ";
            // 
            // lbSo1
            // 
            this.lbSo1.AutoSize = true;
            this.lbSo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo1.ForeColor = System.Drawing.Color.Purple;
            this.lbSo1.Location = new System.Drawing.Point(97, 325);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(173, 190);
            this.lbSo1.TabIndex = 8;
            this.lbSo1.Text = "0";
            // 
            // lbSo2
            // 
            this.lbSo2.AutoSize = true;
            this.lbSo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo2.ForeColor = System.Drawing.Color.Purple;
            this.lbSo2.Location = new System.Drawing.Point(384, 325);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(173, 190);
            this.lbSo2.TabIndex = 9;
            this.lbSo2.Text = "0";
            // 
            // lbSo3
            // 
            this.lbSo3.AutoSize = true;
            this.lbSo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo3.ForeColor = System.Drawing.Color.Purple;
            this.lbSo3.Location = new System.Drawing.Point(654, 325);
            this.lbSo3.Name = "lbSo3";
            this.lbSo3.Size = new System.Drawing.Size(173, 190);
            this.lbSo3.TabIndex = 10;
            this.lbSo3.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(914, 642);
            this.Controls.Add(this.lbSo3);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btTiepTuc);
            this.Controls.Add(this.btSo3);
            this.Controls.Add(this.btSo2);
            this.Controls.Add(this.btSo1);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quay số";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Button btSo1;
        private System.Windows.Forms.Button btSo2;
        private System.Windows.Forms.Button btSo3;
        private System.Windows.Forms.Button btTiepTuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbSo3;
        private System.Windows.Forms.Timer timer1;
    }
}

