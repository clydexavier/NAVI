namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelImage = new System.Windows.Forms.Panel();
            this.PictureBoxSceneImage = new System.Windows.Forms.PictureBox();
            this.PanelListBox = new System.Windows.Forms.Panel();
            this.CheckedListBoxDatapoints = new System.Windows.Forms.CheckedListBox();
            this.ListBoxScenes = new System.Windows.Forms.ListBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileScene = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddScene = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSceneView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemViewScenes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemViewDatapoints = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDatapoints = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddDatapoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDatapointsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectDatapoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDatapointsConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.PanelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSceneImage)).BeginInit();
            this.PanelListBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelImage
            // 
            this.PanelImage.Controls.Add(this.PictureBoxSceneImage);
            this.PanelImage.Controls.Add(this.PanelListBox);
            this.PanelImage.Controls.Add(this.MenuStrip);
            this.PanelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelImage.Location = new System.Drawing.Point(0, 0);
            this.PanelImage.Name = "PanelImage";
            this.PanelImage.Size = new System.Drawing.Size(774, 447);
            this.PanelImage.TabIndex = 0;
            // 
            // PictureBoxSceneImage
            // 
            this.PictureBoxSceneImage.BackColor = System.Drawing.Color.White;
            this.PictureBoxSceneImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxSceneImage.Location = new System.Drawing.Point(0, 24);
            this.PictureBoxSceneImage.Name = "PictureBoxSceneImage";
            this.PictureBoxSceneImage.Size = new System.Drawing.Size(534, 423);
            this.PictureBoxSceneImage.TabIndex = 3;
            this.PictureBoxSceneImage.TabStop = false;
            this.PictureBoxSceneImage.Visible = false;
            this.PictureBoxSceneImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // PanelListBox
            // 
            this.PanelListBox.Controls.Add(this.CheckedListBoxDatapoints);
            this.PanelListBox.Controls.Add(this.ListBoxScenes);
            this.PanelListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelListBox.Location = new System.Drawing.Point(534, 24);
            this.PanelListBox.Name = "PanelListBox";
            this.PanelListBox.Size = new System.Drawing.Size(240, 423);
            this.PanelListBox.TabIndex = 2;
            // 
            // CheckedListBoxDatapoints
            // 
            this.CheckedListBoxDatapoints.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckedListBoxDatapoints.FormattingEnabled = true;
            this.CheckedListBoxDatapoints.Location = new System.Drawing.Point(1, 0);
            this.CheckedListBoxDatapoints.Name = "CheckedListBoxDatapoints";
            this.CheckedListBoxDatapoints.Size = new System.Drawing.Size(120, 423);
            this.CheckedListBoxDatapoints.TabIndex = 6;
            this.CheckedListBoxDatapoints.Visible = false;
            this.CheckedListBoxDatapoints.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxDatapoints_ItemCheck);
            // 
            // ListBoxScenes
            // 
            this.ListBoxScenes.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListBoxScenes.FormattingEnabled = true;
            this.ListBoxScenes.ItemHeight = 15;
            this.ListBoxScenes.Location = new System.Drawing.Point(121, 0);
            this.ListBoxScenes.Name = "ListBoxScenes";
            this.ListBoxScenes.ScrollAlwaysVisible = true;
            this.ListBoxScenes.Size = new System.Drawing.Size(119, 423);
            this.ListBoxScenes.TabIndex = 5;
            this.ListBoxScenes.Visible = false;
            this.ListBoxScenes.SelectedIndexChanged += new System.EventHandler(this.ListBoxScenes_SelectedIndexChanged);
            this.ListBoxScenes.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemView,
            this.MenuItemDatapoints});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(774, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileScene,
            this.MenuItemFileSave,
            this.MenuItemFileOpen,
            this.MenuItemFileSaveAs});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "File";
            // 
            // MenuItemFileScene
            // 
            this.MenuItemFileScene.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddScene,
            this.MenuItemFileSceneView});
            this.MenuItemFileScene.Name = "MenuItemFileScene";
            this.MenuItemFileScene.Size = new System.Drawing.Size(112, 22);
            this.MenuItemFileScene.Text = "Scene";
            // 
            // MenuItemAddScene
            // 
            this.MenuItemAddScene.Name = "MenuItemAddScene";
            this.MenuItemAddScene.Size = new System.Drawing.Size(99, 22);
            this.MenuItemAddScene.Text = "Add";
            this.MenuItemAddScene.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // MenuItemFileSceneView
            // 
            this.MenuItemFileSceneView.Name = "MenuItemFileSceneView";
            this.MenuItemFileSceneView.Size = new System.Drawing.Size(99, 22);
            this.MenuItemFileSceneView.Text = "View";
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.Size = new System.Drawing.Size(112, 22);
            this.MenuItemFileSave.Text = "Save";
            this.MenuItemFileSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.Size = new System.Drawing.Size(112, 22);
            this.MenuItemFileOpen.Text = "Open";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MenuItemFileSaveAs
            // 
            this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
            this.MenuItemFileSaveAs.Size = new System.Drawing.Size(112, 22);
            this.MenuItemFileSaveAs.Text = "Save as";
            this.MenuItemFileSaveAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // MenuItemView
            // 
            this.MenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemViewScenes,
            this.MenuItemViewDatapoints});
            this.MenuItemView.Name = "MenuItemView";
            this.MenuItemView.Size = new System.Drawing.Size(44, 20);
            this.MenuItemView.Text = "View";
            // 
            // MenuItemViewScenes
            // 
            this.MenuItemViewScenes.Name = "MenuItemViewScenes";
            this.MenuItemViewScenes.Size = new System.Drawing.Size(131, 22);
            this.MenuItemViewScenes.Text = "Scenes";
            this.MenuItemViewScenes.Click += new System.EventHandler(this.scenesToolStripMenuItem_Click);
            // 
            // MenuItemViewDatapoints
            // 
            this.MenuItemViewDatapoints.Name = "MenuItemViewDatapoints";
            this.MenuItemViewDatapoints.Size = new System.Drawing.Size(131, 22);
            this.MenuItemViewDatapoints.Text = "DataPoints";
            this.MenuItemViewDatapoints.Click += new System.EventHandler(this.dataPointsToolStripMenuItem_Click);
            // 
            // MenuItemDatapoints
            // 
            this.MenuItemDatapoints.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddDatapoint,
            this.MenuItemDatapointsRemove,
            this.MenuItemConnectDatapoint,
            this.MenuItemDatapointsConnect});
            this.MenuItemDatapoints.Name = "MenuItemDatapoints";
            this.MenuItemDatapoints.Size = new System.Drawing.Size(76, 20);
            this.MenuItemDatapoints.Text = "Datapoints";
            // 
            // MenuItemAddDatapoint
            // 
            this.MenuItemAddDatapoint.Name = "MenuItemAddDatapoint";
            this.MenuItemAddDatapoint.Size = new System.Drawing.Size(119, 22);
            this.MenuItemAddDatapoint.Text = "Add";
            this.MenuItemAddDatapoint.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // MenuItemDatapointsRemove
            // 
            this.MenuItemDatapointsRemove.Name = "MenuItemDatapointsRemove";
            this.MenuItemDatapointsRemove.Size = new System.Drawing.Size(119, 22);
            this.MenuItemDatapointsRemove.Text = "Remove";
            this.MenuItemDatapointsRemove.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // MenuItemConnectDatapoint
            // 
            this.MenuItemConnectDatapoint.Name = "MenuItemConnectDatapoint";
            this.MenuItemConnectDatapoint.Size = new System.Drawing.Size(119, 22);
            this.MenuItemConnectDatapoint.Text = "Connect";
            this.MenuItemConnectDatapoint.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // MenuItemDatapointsConnect
            // 
            this.MenuItemDatapointsConnect.Name = "MenuItemDatapointsConnect";
            this.MenuItemDatapointsConnect.Size = new System.Drawing.Size(119, 22);
            this.MenuItemDatapointsConnect.Text = "Commit";
            this.MenuItemDatapointsConnect.Click += new System.EventHandler(this.commitToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 447);
            this.Controls.Add(this.PanelImage);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "NAVI Encoder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelImage.ResumeLayout(false);
            this.PanelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSceneImage)).EndInit();
            this.PanelListBox.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelImage;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem MenuItemFile;
        private ToolStripMenuItem MenuItemFileScene;
        private ToolStripMenuItem MenuItemAddScene;
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;
        private ToolStripMenuItem MenuItemFileSave;
        private ToolStripMenuItem MenuItemFileOpen;
        private ToolStripMenuItem MenuItemView;
        private ToolStripMenuItem MenuItemViewScenes;
        private ToolStripMenuItem MenuItemViewDatapoints;
        private ToolStripMenuItem MenuItemFileSaveAs;
        private Panel PanelListBox;
        private ListBox ListBoxScenes;
        private PictureBox PictureBoxSceneImage;
        private ToolStripMenuItem MenuItemDatapoints;
        private ToolStripMenuItem MenuItemAddDatapoint;
        private ToolStripMenuItem MenuItemDatapointsRemove;
        private ToolStripMenuItem MenuItemConnectDatapoint;
        private ToolStripMenuItem MenuItemFileSceneView;
        private ToolStripMenuItem MenuItemDatapointsConnect;
        private CheckedListBox CheckedListBoxDatapoints;
    }
}