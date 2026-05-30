namespace Bai1_TuLam_C7
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
            this.pnVe = new System.Windows.Forms.Panel();
            this.btGenerate = new System.Windows.Forms.Button();
            this.txtFri = new System.Windows.Forms.TextBox();
            this.txtThurs = new System.Windows.Forms.TextBox();
            this.txtWed = new System.Windows.Forms.TextBox();
            this.txtTue = new System.Windows.Forms.TextBox();
            this.txtMon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnVe
            // 
            this.pnVe.BackColor = System.Drawing.Color.White;
            this.pnVe.Location = new System.Drawing.Point(89, 259);
            this.pnVe.Name = "pnVe";
            this.pnVe.Size = new System.Drawing.Size(816, 409);
            this.pnVe.TabIndex = 19;
            this.pnVe.Paint += new System.Windows.Forms.PaintEventHandler(this.pnVe_Paint);
            // 
            // btGenerate
            // 
            this.btGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btGenerate.Location = new System.Drawing.Point(89, 199);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(801, 38);
            this.btGenerate.TabIndex = 18;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = false;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // txtFri
            // 
            this.txtFri.Location = new System.Drawing.Point(790, 125);
            this.txtFri.Name = "txtFri";
            this.txtFri.Size = new System.Drawing.Size(100, 30);
            this.txtFri.TabIndex = 17;
            this.txtFri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThurs
            // 
            this.txtThurs.Location = new System.Drawing.Point(618, 125);
            this.txtThurs.Name = "txtThurs";
            this.txtThurs.Size = new System.Drawing.Size(100, 30);
            this.txtThurs.TabIndex = 16;
            this.txtThurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWed
            // 
            this.txtWed.Location = new System.Drawing.Point(446, 125);
            this.txtWed.Name = "txtWed";
            this.txtWed.Size = new System.Drawing.Size(100, 30);
            this.txtWed.TabIndex = 15;
            this.txtWed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTue
            // 
            this.txtTue.Location = new System.Drawing.Point(254, 125);
            this.txtTue.Name = "txtTue";
            this.txtTue.Size = new System.Drawing.Size(100, 30);
            this.txtTue.TabIndex = 14;
            this.txtTue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMon
            // 
            this.txtMon.Location = new System.Drawing.Point(89, 125);
            this.txtMon.Name = "txtMon";
            this.txtMon.Size = new System.Drawing.Size(100, 30);
            this.txtMon.TabIndex = 13;
            this.txtMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "FriDay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "ThursDay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "WednesDay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "TuesDay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Monday";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(986, 693);
            this.Controls.Add(this.pnVe);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.txtFri);
            this.Controls.Add(this.txtThurs);
            this.Controls.Add(this.txtWed);
            this.Controls.Add(this.txtTue);
            this.Controls.Add(this.txtMon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnVe;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TextBox txtFri;
        private System.Windows.Forms.TextBox txtThurs;
        private System.Windows.Forms.TextBox txtWed;
        private System.Windows.Forms.TextBox txtTue;
        private System.Windows.Forms.TextBox txtMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

