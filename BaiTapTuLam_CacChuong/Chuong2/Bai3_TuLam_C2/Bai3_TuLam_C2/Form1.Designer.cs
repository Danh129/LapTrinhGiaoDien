namespace Bai3_TuLam_C2
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 85.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb1.Location = new System.Drawing.Point(89, 67);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(150, 163);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "1";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 85.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb2.Location = new System.Drawing.Point(347, 67);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(150, 163);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "1";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 85.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb3.Location = new System.Drawing.Point(630, 67);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(150, 163);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "1";
            // 
            // lbScore
            // 
            this.lbScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(104, 276);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(685, 69);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbScore.Click += new System.EventHandler(this.lbScore_Click);
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btPlay.Location = new System.Drawing.Point(248, 410);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(134, 53);
            this.btPlay.TabIndex = 4;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btExit.Location = new System.Drawing.Point(544, 410);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(126, 53);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 523);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Random Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btExit;
    }
}

