namespace NaviGUI
{
    partial class NAVI
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
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.ButtonHolder = new System.Windows.Forms.Panel();
            this.ButtonAddImage = new System.Windows.Forms.Button();
            this.ButtonRemoveImage = new System.Windows.Forms.Button();
            this.ButtonRemoveDataPoints = new System.Windows.Forms.Button();
            this.ButtonAddDataPoints = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PBMapContainer = new System.Windows.Forms.PictureBox();
            this.HeadingPanel.SuspendLayout();
            this.ButtonHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMapContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HeadingPanel.Controls.Add(this.ButtonHolder);
            this.HeadingPanel.Controls.Add(this.LabelTitle);
            this.HeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(1000, 50);
            this.HeadingPanel.TabIndex = 0;
            // 
            // ButtonHolder
            // 
            this.ButtonHolder.Controls.Add(this.ButtonAddImage);
            this.ButtonHolder.Controls.Add(this.ButtonRemoveImage);
            this.ButtonHolder.Controls.Add(this.ButtonRemoveDataPoints);
            this.ButtonHolder.Controls.Add(this.ButtonAddDataPoints);
            this.ButtonHolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonHolder.Location = new System.Drawing.Point(459, 0);
            this.ButtonHolder.Name = "ButtonHolder";
            this.ButtonHolder.Size = new System.Drawing.Size(541, 50);
            this.ButtonHolder.TabIndex = 2;
            // 
            // ButtonAddImage
            // 
            this.ButtonAddImage.Location = new System.Drawing.Point(31, 10);
            this.ButtonAddImage.Name = "ButtonAddImage";
            this.ButtonAddImage.Size = new System.Drawing.Size(100, 30);
            this.ButtonAddImage.TabIndex = 3;
            this.ButtonAddImage.Text = "Add Image";
            this.ButtonAddImage.UseVisualStyleBackColor = true;
            this.ButtonAddImage.Click += new System.EventHandler(this.ButtonAddImage_Click);
            // 
            // ButtonRemoveImage
            // 
            this.ButtonRemoveImage.Location = new System.Drawing.Point(153, 10);
            this.ButtonRemoveImage.Name = "ButtonRemoveImage";
            this.ButtonRemoveImage.Size = new System.Drawing.Size(100, 30);
            this.ButtonRemoveImage.TabIndex = 4;
            this.ButtonRemoveImage.Text = "Remove Image";
            this.ButtonRemoveImage.UseVisualStyleBackColor = true;
            // 
            // ButtonRemoveDataPoints
            // 
            this.ButtonRemoveDataPoints.Location = new System.Drawing.Point(400, 10);
            this.ButtonRemoveDataPoints.Name = "ButtonRemoveDataPoints";
            this.ButtonRemoveDataPoints.Size = new System.Drawing.Size(120, 30);
            this.ButtonRemoveDataPoints.TabIndex = 2;
            this.ButtonRemoveDataPoints.Text = "Remove Data Points";
            this.ButtonRemoveDataPoints.UseVisualStyleBackColor = true;
            // 
            // ButtonAddDataPoints
            // 
            this.ButtonAddDataPoints.Location = new System.Drawing.Point(278, 10);
            this.ButtonAddDataPoints.Name = "ButtonAddDataPoints";
            this.ButtonAddDataPoints.Size = new System.Drawing.Size(100, 30);
            this.ButtonAddDataPoints.TabIndex = 1;
            this.ButtonAddDataPoints.Text = "Add Data Points";
            this.ButtonAddDataPoints.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(252, 50);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Navi Map Manager";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBMapContainer
            // 
            this.PBMapContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBMapContainer.Location = new System.Drawing.Point(0, 50);
            this.PBMapContainer.Name = "PBMapContainer";
            this.PBMapContainer.Size = new System.Drawing.Size(1000, 544);
            this.PBMapContainer.TabIndex = 1;
            this.PBMapContainer.TabStop = false;
            // 
            // NAVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 594);
            this.Controls.Add(this.PBMapContainer);
            this.Controls.Add(this.HeadingPanel);
            this.Name = "NAVI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAVI";
            this.HeadingPanel.ResumeLayout(false);
            this.ButtonHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBMapContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel ButtonHolder;
        private System.Windows.Forms.Button ButtonAddImage;
        private System.Windows.Forms.Button ButtonRemoveImage;
        private System.Windows.Forms.Button ButtonRemoveDataPoints;
        private System.Windows.Forms.Button ButtonAddDataPoints;
        private System.Windows.Forms.PictureBox PBMapContainer;
    }
}