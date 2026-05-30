namespace QuaySo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbChay = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pic1 = new PictureBox();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            lbResult = new Label();
            btnQuay = new Button();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            SuspendLayout();
            // 
            // lbChay
            // 
            lbChay.BackColor = Color.Blue;
            lbChay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbChay.ForeColor = Color.White;
            lbChay.Location = new Point(0, 7);
            lbChay.Name = "lbChay";
            lbChay.Size = new Size(805, 83);
            lbChay.TabIndex = 0;
            lbChay.Text = " 2451052243 - Phạm Đức Thắng ";
            lbChay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pic1
            // 
            pic1.Image = Properties.Resources._1;
            pic1.Location = new Point(17, 128);
            pic1.Name = "pic1";
            pic1.Size = new Size(166, 158);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 1;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.Image = Properties.Resources._1;
            pic2.Location = new Point(322, 128);
            pic2.Name = "pic2";
            pic2.Size = new Size(166, 158);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabIndex = 1;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.Image = Properties.Resources._1;
            pic3.Location = new Point(622, 128);
            pic3.Name = "pic3";
            pic3.Size = new Size(166, 158);
            pic3.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3.TabIndex = 1;
            pic3.TabStop = false;
            // 
            // lbResult
            // 
            lbResult.BackColor = Color.Blue;
            lbResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResult.ForeColor = Color.White;
            lbResult.Location = new Point(350, 306);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(119, 83);
            lbResult.TabIndex = 0;
            lbResult.Text = "0";
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnQuay
            // 
            btnQuay.Font = new Font("Segoe UI", 13.8F);
            btnQuay.ForeColor = Color.Blue;
            btnQuay.Location = new Point(246, 405);
            btnQuay.Name = "btnQuay";
            btnQuay.Size = new Size(141, 33);
            btnQuay.TabIndex = 2;
            btnQuay.Text = "QUAY SỐ ";
            btnQuay.UseVisualStyleBackColor = true;
            btnQuay.Click += btnQuay_Click;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 13.8F);
            btnDong.ForeColor = Color.Blue;
            btnDong.Location = new Point(443, 405);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(141, 33);
            btnDong.TabIndex = 2;
            btnDong.Text = "ĐÓNG";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDong);
            Controls.Add(btnQuay);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Controls.Add(pic1);
            Controls.Add(lbResult);
            Controls.Add(lbChay);
            Name = "Form1";
            Text = "Mini Game";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbChay;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private Label lbResult;
        private Button btnQuay;
        private Button btnDong;
    }
}
