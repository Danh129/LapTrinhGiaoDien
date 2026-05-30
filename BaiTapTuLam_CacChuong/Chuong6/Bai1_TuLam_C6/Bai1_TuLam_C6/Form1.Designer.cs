namespace Bai1_TuLam_C6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboDrives = new System.Windows.Forms.ComboBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lvFile = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLargeIcon = new System.Windows.Forms.RadioButton();
            this.rdSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdList = new System.Windows.Forms.RadioButton();
            this.rdDetail = new System.Windows.Forms.RadioButton();
            this.rdTile = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDrives
            // 
            this.cboDrives.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDrives.FormattingEnabled = true;
            this.cboDrives.Location = new System.Drawing.Point(52, 31);
            this.cboDrives.Name = "cboDrives";
            this.cboDrives.Size = new System.Drawing.Size(138, 33);
            this.cboDrives.TabIndex = 0;
            this.cboDrives.SelectedIndexChanged += new System.EventHandler(this.cboDrives_SelectedIndexChanged);
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.Location = new System.Drawing.Point(234, 31);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(95, 32);
            this.lblPath.TabIndex = 1;
            // 
            // lvFile
            // 
            this.lvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvFile.HideSelection = false;
            this.lvFile.Location = new System.Drawing.Point(27, 101);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(734, 553);
            this.lvFile.TabIndex = 2;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            this.lvFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFile_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last accessed";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.rdTile);
            this.groupBox1.Controls.Add(this.rdDetail);
            this.groupBox1.Controls.Add(this.rdList);
            this.groupBox1.Controls.Add(this.rdSmallIcon);
            this.groupBox1.Controls.Add(this.rdLargeIcon);
            this.groupBox1.Location = new System.Drawing.Point(782, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 553);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Mode";
            // 
            // rdLargeIcon
            // 
            this.rdLargeIcon.AutoSize = true;
            this.rdLargeIcon.Location = new System.Drawing.Point(27, 65);
            this.rdLargeIcon.Name = "rdLargeIcon";
            this.rdLargeIcon.Size = new System.Drawing.Size(120, 29);
            this.rdLargeIcon.TabIndex = 0;
            this.rdLargeIcon.TabStop = true;
            this.rdLargeIcon.Text = "LargeIcon";
            this.rdLargeIcon.UseVisualStyleBackColor = true;
            this.rdLargeIcon.CheckedChanged += new System.EventHandler(this.rdLargeIcon_CheckedChanged);
            // 
            // rdSmallIcon
            // 
            this.rdSmallIcon.AutoSize = true;
            this.rdSmallIcon.Location = new System.Drawing.Point(27, 137);
            this.rdSmallIcon.Name = "rdSmallIcon";
            this.rdSmallIcon.Size = new System.Drawing.Size(119, 29);
            this.rdSmallIcon.TabIndex = 1;
            this.rdSmallIcon.TabStop = true;
            this.rdSmallIcon.Text = "SmallIcon";
            this.rdSmallIcon.UseVisualStyleBackColor = true;
            this.rdSmallIcon.CheckedChanged += new System.EventHandler(this.rdSmallIcon_CheckedChanged);
            // 
            // rdList
            // 
            this.rdList.AutoSize = true;
            this.rdList.Location = new System.Drawing.Point(27, 211);
            this.rdList.Name = "rdList";
            this.rdList.Size = new System.Drawing.Size(63, 29);
            this.rdList.TabIndex = 2;
            this.rdList.TabStop = true;
            this.rdList.Text = "List";
            this.rdList.UseVisualStyleBackColor = true;
            this.rdList.CheckedChanged += new System.EventHandler(this.rdList_CheckedChanged);
            // 
            // rdDetail
            // 
            this.rdDetail.AutoSize = true;
            this.rdDetail.Location = new System.Drawing.Point(27, 289);
            this.rdDetail.Name = "rdDetail";
            this.rdDetail.Size = new System.Drawing.Size(82, 29);
            this.rdDetail.TabIndex = 3;
            this.rdDetail.TabStop = true;
            this.rdDetail.Text = "Detail";
            this.rdDetail.UseVisualStyleBackColor = true;
            this.rdDetail.CheckedChanged += new System.EventHandler(this.rdDetail_CheckedChanged);
            // 
            // rdTile
            // 
            this.rdTile.AutoSize = true;
            this.rdTile.Location = new System.Drawing.Point(27, 365);
            this.rdTile.Name = "rdTile";
            this.rdTile.Size = new System.Drawing.Size(65, 29);
            this.rdTile.TabIndex = 4;
            this.rdTile.TabStop = true;
            this.rdTile.Text = "Tile";
            this.rdTile.UseVisualStyleBackColor = true;
            this.rdTile.CheckedChanged += new System.EventHandler(this.rdTile_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.jpg");
            this.imageList1.Images.SetKeyName(1, "IconFile.png");
            this.imageList1.Images.SetKeyName(2, "0.jpg");
            this.imageList1.Images.SetKeyName(3, "1.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1004, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.cboDrives);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDrives;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTile;
        private System.Windows.Forms.RadioButton rdDetail;
        private System.Windows.Forms.RadioButton rdList;
        private System.Windows.Forms.RadioButton rdSmallIcon;
        private System.Windows.Forms.RadioButton rdLargeIcon;
        private System.Windows.Forms.ImageList imageList1;
    }
}

