namespace C4_bai2
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
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.listBoxTrai = new System.Windows.Forms.ListBox();
            this.listBoxPhai = new System.Windows.Forms.ListBox();
            this.btTraiSangPhai = new System.Windows.Forms.Button();
            this.btPhaiSangTrai = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.comboBoxMau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một chuỗi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(550, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn màu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChuoi
            // 
            this.txtChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoi.Location = new System.Drawing.Point(58, 92);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(176, 30);
            this.txtChuoi.TabIndex = 1;
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.ForeColor = System.Drawing.Color.Blue;
            this.btInsert.Location = new System.Drawing.Point(56, 144);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(116, 44);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // listBoxTrai
            // 
            this.listBoxTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTrai.FormattingEnabled = true;
            this.listBoxTrai.ItemHeight = 25;
            this.listBoxTrai.Location = new System.Drawing.Point(56, 205);
            this.listBoxTrai.Name = "listBoxTrai";
            this.listBoxTrai.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTrai.Size = new System.Drawing.Size(239, 329);
            this.listBoxTrai.TabIndex = 3;
            // 
            // listBoxPhai
            // 
            this.listBoxPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPhai.FormattingEnabled = true;
            this.listBoxPhai.ItemHeight = 25;
            this.listBoxPhai.Location = new System.Drawing.Point(555, 205);
            this.listBoxPhai.Name = "listBoxPhai";
            this.listBoxPhai.Size = new System.Drawing.Size(241, 329);
            this.listBoxPhai.TabIndex = 4;
            // 
            // btTraiSangPhai
            // 
            this.btTraiSangPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraiSangPhai.ForeColor = System.Drawing.Color.Blue;
            this.btTraiSangPhai.Location = new System.Drawing.Point(355, 229);
            this.btTraiSangPhai.Name = "btTraiSangPhai";
            this.btTraiSangPhai.Size = new System.Drawing.Size(134, 43);
            this.btTraiSangPhai.TabIndex = 5;
            this.btTraiSangPhai.Text = "==>";
            this.btTraiSangPhai.UseVisualStyleBackColor = true;
            this.btTraiSangPhai.Click += new System.EventHandler(this.btTraiSangPhai_Click);
            // 
            // btPhaiSangTrai
            // 
            this.btPhaiSangTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhaiSangTrai.ForeColor = System.Drawing.Color.Blue;
            this.btPhaiSangTrai.Location = new System.Drawing.Point(355, 301);
            this.btPhaiSangTrai.Name = "btPhaiSangTrai";
            this.btPhaiSangTrai.Size = new System.Drawing.Size(134, 38);
            this.btPhaiSangTrai.TabIndex = 5;
            this.btPhaiSangTrai.Text = "<==";
            this.btPhaiSangTrai.UseVisualStyleBackColor = true;
            this.btPhaiSangTrai.Click += new System.EventHandler(this.btPhaiSangTrai_Click);
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.ForeColor = System.Drawing.Color.Blue;
            this.btRemove.Location = new System.Drawing.Point(355, 367);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(134, 41);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Blue;
            this.btExit.Location = new System.Drawing.Point(355, 494);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(134, 40);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.Blue;
            this.btClear.Location = new System.Drawing.Point(355, 434);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(134, 40);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "Clear ALL";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // comboBoxMau
            // 
            this.comboBoxMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMau.FormattingEnabled = true;
            this.comboBoxMau.Location = new System.Drawing.Point(555, 89);
            this.comboBoxMau.Name = "comboBoxMau";
            this.comboBoxMau.Size = new System.Drawing.Size(241, 33);
            this.comboBoxMau.TabIndex = 9;
            this.comboBoxMau.SelectedIndexChanged += new System.EventHandler(this.comboBoxMau_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 593);
            this.Controls.Add(this.comboBoxMau);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btPhaiSangTrai);
            this.Controls.Add(this.btTraiSangPhai);
            this.Controls.Add(this.listBoxPhai);
            this.Controls.Add(this.listBoxTrai);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai2_TuLam_C4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.ListBox listBoxTrai;
        private System.Windows.Forms.ListBox listBoxPhai;
        private System.Windows.Forms.Button btTraiSangPhai;
        private System.Windows.Forms.Button btPhaiSangTrai;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox comboBoxMau;
    }
}

