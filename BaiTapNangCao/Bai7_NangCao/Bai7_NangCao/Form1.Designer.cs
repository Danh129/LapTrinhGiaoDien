namespace Bai7_NangCao
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btChuanBi = new System.Windows.Forms.Button();
            this.btChay = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.picCho = new System.Windows.Forms.PictureBox();
            this.picTho = new System.Windows.Forms.PictureBox();
            this.picRua = new System.Windows.Forms.PictureBox();
            this.lbCho = new System.Windows.Forms.Label();
            this.lbTho = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.panelRua = new System.Windows.Forms.Panel();
            this.panelTho = new System.Windows.Forms.Panel();
            this.panelCho = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua)).BeginInit();
            this.panelRua.SuspendLayout();
            this.panelTho.SuspendLayout();
            this.panelCho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(272, 9);
            this.lbTitle.MaximumSize = new System.Drawing.Size(0, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(322, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "CUOC DUA KI THU";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btChuanBi
            // 
            this.btChuanBi.BackColor = System.Drawing.Color.White;
            this.btChuanBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuanBi.Location = new System.Drawing.Point(13, 72);
            this.btChuanBi.Name = "btChuanBi";
            this.btChuanBi.Size = new System.Drawing.Size(109, 40);
            this.btChuanBi.TabIndex = 1;
            this.btChuanBi.Text = "Chuan bi";
            this.btChuanBi.UseVisualStyleBackColor = false;
            this.btChuanBi.Click += new System.EventHandler(this.btChuanBi_Click);
            // 
            // btChay
            // 
            this.btChay.BackColor = System.Drawing.Color.White;
            this.btChay.Enabled = false;
            this.btChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChay.Location = new System.Drawing.Point(13, 130);
            this.btChay.Name = "btChay";
            this.btChay.Size = new System.Drawing.Size(108, 32);
            this.btChay.TabIndex = 2;
            this.btChay.Text = "Chay";
            this.btChay.UseVisualStyleBackColor = false;
            this.btChay.Click += new System.EventHandler(this.btChay_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.BackColor = System.Drawing.Color.Silver;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.ForeColor = System.Drawing.Color.Red;
            this.lbKetQua.Location = new System.Drawing.Point(9, 223);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(888, 49);
            this.lbKetQua.TabIndex = 3;
            this.lbKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCho
            // 
            this.picCho.Image = global::Bai7_NangCao.Properties.Resources.cho;
            this.picCho.Location = new System.Drawing.Point(13, 10);
            this.picCho.Name = "picCho";
            this.picCho.Size = new System.Drawing.Size(100, 81);
            this.picCho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCho.TabIndex = 4;
            this.picCho.TabStop = false;
            // 
            // picTho
            // 
            this.picTho.Image = global::Bai7_NangCao.Properties.Resources.tho;
            this.picTho.Location = new System.Drawing.Point(13, 17);
            this.picTho.Name = "picTho";
            this.picTho.Size = new System.Drawing.Size(100, 81);
            this.picTho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTho.TabIndex = 5;
            this.picTho.TabStop = false;
            // 
            // picRua
            // 
            this.picRua.Image = global::Bai7_NangCao.Properties.Resources.rua;
            this.picRua.Location = new System.Drawing.Point(5, 3);
            this.picRua.Name = "picRua";
            this.picRua.Size = new System.Drawing.Size(100, 81);
            this.picRua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRua.TabIndex = 6;
            this.picRua.TabStop = false;
            // 
            // lbCho
            // 
            this.lbCho.AutoSize = true;
            this.lbCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCho.Location = new System.Drawing.Point(299, 177);
            this.lbCho.Name = "lbCho";
            this.lbCho.Size = new System.Drawing.Size(34, 25);
            this.lbCho.TabIndex = 7;
            this.lbCho.Text = "00";
            // 
            // lbTho
            // 
            this.lbTho.AutoSize = true;
            this.lbTho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTho.Location = new System.Drawing.Point(509, 177);
            this.lbTho.Name = "lbTho";
            this.lbTho.Size = new System.Drawing.Size(34, 25);
            this.lbTho.TabIndex = 8;
            this.lbTho.Text = "00";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRua.Location = new System.Drawing.Point(718, 177);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(34, 25);
            this.lbRua.TabIndex = 9;
            this.lbRua.Text = "00";
            // 
            // panelRua
            // 
            this.panelRua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRua.Controls.Add(this.picRua);
            this.panelRua.Location = new System.Drawing.Point(9, 303);
            this.panelRua.Name = "panelRua";
            this.panelRua.Size = new System.Drawing.Size(888, 104);
            this.panelRua.TabIndex = 10;
            // 
            // panelTho
            // 
            this.panelTho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTho.Controls.Add(this.picTho);
            this.panelTho.Location = new System.Drawing.Point(9, 425);
            this.panelTho.Name = "panelTho";
            this.panelTho.Size = new System.Drawing.Size(888, 101);
            this.panelTho.TabIndex = 11;
            // 
            // panelCho
            // 
            this.panelCho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCho.Controls.Add(this.picCho);
            this.panelCho.Location = new System.Drawing.Point(9, 541);
            this.panelCho.Name = "panelCho";
            this.panelCho.Size = new System.Drawing.Size(883, 94);
            this.panelCho.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bai7_NangCao.Properties.Resources.cho;
            this.pictureBox1.Location = new System.Drawing.Point(248, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bai7_NangCao.Properties.Resources.tho;
            this.pictureBox2.Location = new System.Drawing.Point(454, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bai7_NangCao.Properties.Resources.rua;
            this.pictureBox3.Location = new System.Drawing.Point(675, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 647);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelCho);
            this.Controls.Add(this.panelTho);
            this.Controls.Add(this.panelRua);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.lbTho);
            this.Controls.Add(this.lbCho);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btChay);
            this.Controls.Add(this.btChuanBi);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bai7";
            ((System.ComponentModel.ISupportInitialize)(this.picCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua)).EndInit();
            this.panelRua.ResumeLayout(false);
            this.panelTho.ResumeLayout(false);
            this.panelCho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btChuanBi;
        private System.Windows.Forms.Button btChay;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.PictureBox picCho;
        private System.Windows.Forms.PictureBox picTho;
        private System.Windows.Forms.PictureBox picRua;
        private System.Windows.Forms.Label lbCho;
        private System.Windows.Forms.Label lbTho;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Panel panelRua;
        private System.Windows.Forms.Panel panelTho;
        private System.Windows.Forms.Panel panelCho;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

