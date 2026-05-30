namespace Bai2_TuLam_C7
{
    partial class FrmOption
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
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.rdTriangle = new System.Windows.Forms.RadioButton();
            this.rdEllipse = new System.Windows.Forms.RadioButton();
            this.rdRectangle = new System.Windows.Forms.RadioButton();
            this.pnColor = new System.Windows.Forms.Panel();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.grpShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.rdTriangle);
            this.grpShapes.Controls.Add(this.rdEllipse);
            this.grpShapes.Controls.Add(this.rdRectangle);
            this.grpShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShapes.Location = new System.Drawing.Point(29, 28);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Size = new System.Drawing.Size(510, 235);
            this.grpShapes.TabIndex = 0;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Shapes";
            // 
            // rdTriangle
            // 
            this.rdTriangle.AutoSize = true;
            this.rdTriangle.Location = new System.Drawing.Point(39, 155);
            this.rdTriangle.Name = "rdTriangle";
            this.rdTriangle.Size = new System.Drawing.Size(104, 29);
            this.rdTriangle.TabIndex = 2;
            this.rdTriangle.TabStop = true;
            this.rdTriangle.Text = "Triangle";
            this.rdTriangle.UseVisualStyleBackColor = true;
            // 
            // rdEllipse
            // 
            this.rdEllipse.AutoSize = true;
            this.rdEllipse.Location = new System.Drawing.Point(39, 103);
            this.rdEllipse.Name = "rdEllipse";
            this.rdEllipse.Size = new System.Drawing.Size(86, 29);
            this.rdEllipse.TabIndex = 1;
            this.rdEllipse.TabStop = true;
            this.rdEllipse.Text = "Elipse";
            this.rdEllipse.UseVisualStyleBackColor = true;
            // 
            // rdRectangle
            // 
            this.rdRectangle.AutoSize = true;
            this.rdRectangle.Location = new System.Drawing.Point(39, 56);
            this.rdRectangle.Name = "rdRectangle";
            this.rdRectangle.Size = new System.Drawing.Size(120, 29);
            this.rdRectangle.TabIndex = 0;
            this.rdRectangle.TabStop = true;
            this.rdRectangle.Text = "Rectangle";
            this.rdRectangle.UseVisualStyleBackColor = true;
            // 
            // pnColor
            // 
            this.pnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnColor.Location = new System.Drawing.Point(29, 307);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(510, 38);
            this.pnColor.TabIndex = 1;
            this.pnColor.Click += new System.EventHandler(this.pnColor_Click);
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(107, 396);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(122, 30);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(308, 396);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(116, 31);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 468);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.pnColor);
            this.Controls.Add(this.grpShapes);
            this.Name = "FrmOption";
            this.Text = "FrmOption";
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.Panel pnColor;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.RadioButton rdTriangle;
        private System.Windows.Forms.RadioButton rdEllipse;
        private System.Windows.Forms.RadioButton rdRectangle;
    }
}