namespace Bai2_TuLam_C3
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCanhA = new System.Windows.Forms.TextBox();
            this.txtCanhB = new System.Windows.Forms.TextBox();
            this.txtCanhC = new System.Windows.Forms.TextBox();
            this.btTinh = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbKq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cạnh a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cạnh b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cạnh c =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            // 
            // txtCanhA
            // 
            this.txtCanhA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanhA.Location = new System.Drawing.Point(213, 55);
            this.txtCanhA.Name = "txtCanhA";
            this.txtCanhA.Size = new System.Drawing.Size(100, 34);
            this.txtCanhA.TabIndex = 4;
            // 
            // txtCanhB
            // 
            this.txtCanhB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanhB.Location = new System.Drawing.Point(213, 130);
            this.txtCanhB.Name = "txtCanhB";
            this.txtCanhB.Size = new System.Drawing.Size(100, 34);
            this.txtCanhB.TabIndex = 5;
            // 
            // txtCanhC
            // 
            this.txtCanhC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanhC.Location = new System.Drawing.Point(213, 206);
            this.txtCanhC.Name = "txtCanhC";
            this.txtCanhC.Size = new System.Drawing.Size(100, 34);
            this.txtCanhC.TabIndex = 6;
            // 
            // btTinh
            // 
            this.btTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTinh.Location = new System.Drawing.Point(489, 83);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(145, 40);
            this.btTinh.TabIndex = 8;
            this.btTinh.Text = "Tính Toán";
            this.btTinh.UseVisualStyleBackColor = false;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(489, 182);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(145, 36);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lbKq
            // 
            this.lbKq.BackColor = System.Drawing.Color.White;
            this.lbKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKq.Location = new System.Drawing.Point(166, 299);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(431, 111);
            this.lbKq.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.txtCanhC);
            this.Controls.Add(this.txtCanhB);
            this.Controls.Add(this.txtCanhA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCanhA;
        private System.Windows.Forms.TextBox txtCanhB;
        private System.Windows.Forms.TextBox txtCanhC;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label lbKq;
    }
}

