namespace Bai8_NangCao
{
    partial class FrmUpdate
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
            this.txtUpName = new System.Windows.Forms.TextBox();
            this.txtUpPrice = new System.Windows.Forms.TextBox();
            this.btFrOK = new System.Windows.Forms.Button();
            this.btFrCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // txtUpName
            // 
            this.txtUpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpName.Location = new System.Drawing.Point(205, 73);
            this.txtUpName.Name = "txtUpName";
            this.txtUpName.ReadOnly = true;
            this.txtUpName.Size = new System.Drawing.Size(224, 30);
            this.txtUpName.TabIndex = 2;
            // 
            // txtUpPrice
            // 
            this.txtUpPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpPrice.Location = new System.Drawing.Point(205, 151);
            this.txtUpPrice.Name = "txtUpPrice";
            this.txtUpPrice.Size = new System.Drawing.Size(224, 30);
            this.txtUpPrice.TabIndex = 3;
            // 
            // btFrOK
            // 
            this.btFrOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFrOK.Location = new System.Drawing.Point(109, 228);
            this.btFrOK.Name = "btFrOK";
            this.btFrOK.Size = new System.Drawing.Size(111, 36);
            this.btFrOK.TabIndex = 4;
            this.btFrOK.Text = "OK";
            this.btFrOK.UseVisualStyleBackColor = true;
            this.btFrOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btFrCancel
            // 
            this.btFrCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFrCancel.Location = new System.Drawing.Point(291, 228);
            this.btFrCancel.Name = "btFrCancel";
            this.btFrCancel.Size = new System.Drawing.Size(90, 34);
            this.btFrCancel.TabIndex = 5;
            this.btFrCancel.Text = "Cancel";
            this.btFrCancel.UseVisualStyleBackColor = true;
            this.btFrCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 312);
            this.Controls.Add(this.btFrCancel);
            this.Controls.Add(this.btFrOK);
            this.Controls.Add(this.txtUpPrice);
            this.Controls.Add(this.txtUpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdate";
            this.Text = "FrmUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpName;
        private System.Windows.Forms.TextBox txtUpPrice;
        private System.Windows.Forms.Button btFrOK;
        private System.Windows.Forms.Button btFrCancel;
    }
}