namespace C4_Bai4
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
            this.btTapTin = new System.Windows.Forms.Button();
            this.btNhieuTapTin = new System.Windows.Forms.Button();
            this.btThuMuc = new System.Windows.Forms.Button();
            this.btMauNen = new System.Windows.Forms.Button();
            this.btMauChu = new System.Windows.Forms.Button();
            this.btFont = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtNodung = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btTapTin
            // 
            this.btTapTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTapTin.Location = new System.Drawing.Point(39, 28);
            this.btTapTin.Name = "btTapTin";
            this.btTapTin.Size = new System.Drawing.Size(223, 44);
            this.btTapTin.TabIndex = 0;
            this.btTapTin.Text = "Chọn một tập tin";
            this.btTapTin.UseVisualStyleBackColor = true;
            this.btTapTin.Click += new System.EventHandler(this.btTapTin_Click);
            // 
            // btNhieuTapTin
            // 
            this.btNhieuTapTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhieuTapTin.Location = new System.Drawing.Point(39, 93);
            this.btNhieuTapTin.Name = "btNhieuTapTin";
            this.btNhieuTapTin.Size = new System.Drawing.Size(223, 44);
            this.btNhieuTapTin.TabIndex = 0;
            this.btNhieuTapTin.Text = "Chọn nhiều tập tin";
            this.btNhieuTapTin.UseVisualStyleBackColor = true;
            this.btNhieuTapTin.Click += new System.EventHandler(this.btNhieuTapTin_Click);
            // 
            // btThuMuc
            // 
            this.btThuMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThuMuc.Location = new System.Drawing.Point(39, 168);
            this.btThuMuc.Name = "btThuMuc";
            this.btThuMuc.Size = new System.Drawing.Size(223, 44);
            this.btThuMuc.TabIndex = 0;
            this.btThuMuc.Text = "Chọn thư mục";
            this.btThuMuc.UseVisualStyleBackColor = true;
            this.btThuMuc.Click += new System.EventHandler(this.btThuMuc_Click);
            // 
            // btMauNen
            // 
            this.btMauNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMauNen.Location = new System.Drawing.Point(39, 240);
            this.btMauNen.Name = "btMauNen";
            this.btMauNen.Size = new System.Drawing.Size(223, 44);
            this.btMauNen.TabIndex = 0;
            this.btMauNen.Text = "Chọn màu nền";
            this.btMauNen.UseVisualStyleBackColor = true;
            this.btMauNen.Click += new System.EventHandler(this.btMauNen_Click);
            // 
            // btMauChu
            // 
            this.btMauChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMauChu.Location = new System.Drawing.Point(39, 308);
            this.btMauChu.Name = "btMauChu";
            this.btMauChu.Size = new System.Drawing.Size(223, 44);
            this.btMauChu.TabIndex = 0;
            this.btMauChu.Text = "Chọn màu chữ";
            this.btMauChu.UseVisualStyleBackColor = true;
            this.btMauChu.Click += new System.EventHandler(this.btMauChu_Click);
            // 
            // btFont
            // 
            this.btFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFont.Location = new System.Drawing.Point(39, 374);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(223, 44);
            this.btFont.TabIndex = 0;
            this.btFont.Text = "Chọn font";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(319, 374);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(202, 44);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(542, 374);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(202, 44);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtNodung
            // 
            this.txtNodung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodung.Location = new System.Drawing.Point(319, 28);
            this.txtNodung.Multiline = true;
            this.txtNodung.Name = "txtNodung";
            this.txtNodung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNodung.Size = new System.Drawing.Size(425, 324);
            this.txtNodung.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNodung);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btFont);
            this.Controls.Add(this.btMauChu);
            this.Controls.Add(this.btMauNen);
            this.Controls.Add(this.btThuMuc);
            this.Controls.Add(this.btNhieuTapTin);
            this.Controls.Add(this.btTapTin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btTapTin;
        private System.Windows.Forms.Button btNhieuTapTin;
        private System.Windows.Forms.Button btThuMuc;
        private System.Windows.Forms.Button btMauNen;
        private System.Windows.Forms.Button btMauChu;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtNodung;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer2;
    }
}

