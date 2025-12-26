namespace Tyuiu.BalinVV.Sprint7.Project.V3
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.pictureBox_BVV = new System.Windows.Forms.PictureBox();
            this.labelInfo_BVV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BVV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_BVV
            // 
            this.pictureBox_BVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox_BVV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_BVV.Image")));
            this.pictureBox_BVV.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_BVV.Name = "pictureBox_BVV";
            this.pictureBox_BVV.Size = new System.Drawing.Size(911, 278);
            this.pictureBox_BVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_BVV.TabIndex = 0;
            this.pictureBox_BVV.TabStop = false;
            this.pictureBox_BVV.Click += new System.EventHandler(this.pictureBox_BVV_Click);
            // 
            // labelInfo_BVV
            // 
            this.labelInfo_BVV.AutoSize = true;
            this.labelInfo_BVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelInfo_BVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.8F, System.Drawing.FontStyle.Bold);
            this.labelInfo_BVV.Location = new System.Drawing.Point(49, 293);
            this.labelInfo_BVV.Name = "labelInfo_BVV";
            this.labelInfo_BVV.Size = new System.Drawing.Size(818, 148);
            this.labelInfo_BVV.TabIndex = 1;
            this.labelInfo_BVV.Text = "Разработчик: Исаев.М.А.\r\nГруппа АСОИУБ-23-3";
            this.labelInfo_BVV.Click += new System.EventHandler(this.labelInfo_BVV_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.labelInfo_BVV);
            this.Controls.Add(this.pictureBox_BVV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_BVV;
        private System.Windows.Forms.Label labelInfo_BVV;
    }
}
   