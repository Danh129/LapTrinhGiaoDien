namespace Bai6_TuLam_C2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btTimTen = new System.Windows.Forms.Button();
            this.btTimMa = new System.Windows.Forms.Button();
            this.btSapXep = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Họ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(48, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(48, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập Mã:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(202, 42);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(177, 30);
            this.txtHo.TabIndex = 3;
            this.txtHo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(202, 97);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(177, 30);
            this.txtTen.TabIndex = 4;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(202, 153);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(177, 30);
            this.txtMa.TabIndex = 5;
            this.txtMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btTimTen
            // 
            this.btTimTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btTimTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btTimTen.Location = new System.Drawing.Point(457, 117);
            this.btTimTen.Name = "btTimTen";
            this.btTimTen.Size = new System.Drawing.Size(117, 41);
            this.btTimTen.TabIndex = 6;
            this.btTimTen.Text = "Tìm Tên";
            this.btTimTen.UseVisualStyleBackColor = false;
            this.btTimTen.Click += new System.EventHandler(this.btTimTen_Click);
            // 
            // btTimMa
            // 
            this.btTimMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btTimMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btTimMa.Location = new System.Drawing.Point(656, 42);
            this.btTimMa.Name = "btTimMa";
            this.btTimMa.Size = new System.Drawing.Size(121, 37);
            this.btTimMa.TabIndex = 7;
            this.btTimMa.Text = "Tìm Mã";
            this.btTimMa.UseVisualStyleBackColor = false;
            this.btTimMa.Click += new System.EventHandler(this.btTimMa_Click);
            // 
            // btSapXep
            // 
            this.btSapXep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btSapXep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btSapXep.Location = new System.Drawing.Point(656, 117);
            this.btSapXep.Name = "btSapXep";
            this.btSapXep.Size = new System.Drawing.Size(121, 41);
            this.btSapXep.TabIndex = 8;
            this.btSapXep.Text = "Sắp xếp";
            this.btSapXep.UseVisualStyleBackColor = false;
            this.btSapXep.Click += new System.EventHandler(this.btSapXep_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btThem.Location = new System.Drawing.Point(457, 42);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(117, 37);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(76, 231);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(777, 381);
            this.dgvSinhVien.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(917, 624);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSapXep);
            this.Controls.Add(this.btTimMa);
            this.Controls.Add(this.btTimTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bai 6 Chuong 2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btTimTen;
        private System.Windows.Forms.Button btTimMa;
        private System.Windows.Forms.Button btSapXep;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvSinhVien;
    }
}

