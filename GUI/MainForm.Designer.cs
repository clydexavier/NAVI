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
            this.PanelAllListBox = new System.Windows.Forms.Panel();
            this.ListBoxScenes = new System.Windows.Forms.ListBox();
            this.ListBoxDatapoints = new System.Windows.Forms.ListBox();
            this.PanelAuxButton = new System.Windows.Forms.Panel();
            this.LabelDistance = new System.Windows.Forms.Label();
            this.LabelDirection = new System.Windows.Forms.Label();
            this.LabelTo = new System.Windows.Forms.Label();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.TextBoxDistance = new System.Windows.Forms.TextBox();
            this.ComboBoxDirection = new System.Windows.Forms.ComboBox();
            this.ComboBoxToDatapoints = new System.Windows.Forms.ComboBox();
            this.ComboBoxFromDatapoints = new System.Windows.Forms.ComboBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileScene = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddScene = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSceneView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.commitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCommitSceneDatapoints = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCommitAllDatapoints = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemViewScenes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemViewDatapoints = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDatapoints = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddDatapoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDatapointsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectDatapoint = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.undoCommitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSceneImage)).BeginInit();
            this.PanelListBox.SuspendLayout();
            this.PanelAllListBox.SuspendLayout();
            this.PanelAuxButton.SuspendLayout();
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
            this.PanelListBox.Controls.Add(this.PanelAllListBox);
            this.PanelListBox.Controls.Add(this.PanelAuxButton);
            this.PanelListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelListBox.Location = new System.Drawing.Point(534, 24);
            this.PanelListBox.Name = "PanelListBox";
            this.PanelListBox.Size = new System.Drawing.Size(240, 423);
            this.PanelListBox.TabIndex = 2;
            // 
            // PanelAllListBox
            // 
            this.PanelAllListBox.Controls.Add(this.ListBoxScenes);
            this.PanelAllListBox.Controls.Add(this.ListBoxDatapoints);
            this.PanelAllListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAllListBox.Location = new System.Drawing.Point(0, 0);
            this.PanelAllListBox.Name = "PanelAllListBox";
            this.PanelAllListBox.Size = new System.Drawing.Size(240, 257);
            this.PanelAllListBox.TabIndex = 1;
            // 
            // ListBoxScenes
            // 
            this.ListBoxScenes.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxScenes.FormattingEnabled = true;
            this.ListBoxScenes.ItemHeight = 15;
            this.ListBoxScenes.Location = new System.Drawing.Point(0, 0);
            this.ListBoxScenes.Name = "ListBoxScenes";
            this.ListBoxScenes.Size = new System.Drawing.Size(120, 257);
            this.ListBoxScenes.TabIndex = 1;
            this.ListBoxScenes.Visible = false;
            // 
            // ListBoxDatapoints
            // 
            this.ListBoxDatapoints.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListBoxDatapoints.FormattingEnabled = true;
            this.ListBoxDatapoints.ItemHeight = 15;
            this.ListBoxDatapoints.Location = new System.Drawing.Point(120, 0);
            this.ListBoxDatapoints.Name = "ListBoxDatapoints";
            this.ListBoxDatapoints.Size = new System.Drawing.Size(120, 257);
            this.ListBoxDatapoints.TabIndex = 0;
            this.ListBoxDatapoints.Visible = false;
            // 
            // PanelAuxButton
            // 
            this.PanelAuxButton.Controls.Add(this.LabelDistance);
            this.PanelAuxButton.Controls.Add(this.LabelDirection);
            this.PanelAuxButton.Controls.Add(this.LabelTo);
            this.PanelAuxButton.Controls.Add(this.LabelFrom);
            this.PanelAuxButton.Controls.Add(this.ButtonConnect);
            this.PanelAuxButton.Controls.Add(this.TextBoxDistance);
            this.PanelAuxButton.Controls.Add(this.ComboBoxDirection);
            this.PanelAuxButton.Controls.Add(this.ComboBoxToDatapoints);
            this.PanelAuxButton.Controls.Add(this.ComboBoxFromDatapoints);
            this.PanelAuxButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelAuxButton.Location = new System.Drawing.Point(0, 257);
            this.PanelAuxButton.Name = "PanelAuxButton";
            this.PanelAuxButton.Size = new System.Drawing.Size(240, 166);
            this.PanelAuxButton.TabIndex = 0;
            // 
            // LabelDistance
            // 
            this.LabelDistance.AutoSize = true;
            this.LabelDistance.Location = new System.Drawing.Point(135, 68);
            this.LabelDistance.Name = "LabelDistance";
            this.LabelDistance.Size = new System.Drawing.Size(52, 15);
            this.LabelDistance.TabIndex = 8;
            this.LabelDistance.Text = "Distance";
            this.LabelDistance.Visible = false;
            // 
            // LabelDirection
            // 
            this.LabelDirection.AutoSize = true;
            this.LabelDirection.Location = new System.Drawing.Point(17, 68);
            this.LabelDirection.Name = "LabelDirection";
            this.LabelDirection.Size = new System.Drawing.Size(55, 15);
            this.LabelDirection.TabIndex = 7;
            this.LabelDirection.Text = "Direction";
            this.LabelDirection.Visible = false;
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Location = new System.Drawing.Point(135, 11);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(19, 15);
            this.LabelTo.TabIndex = 6;
            this.LabelTo.Text = "To";
            this.LabelTo.Visible = false;
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Location = new System.Drawing.Point(17, 11);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(35, 15);
            this.LabelFrom.TabIndex = 5;
            this.LabelFrom.Text = "From";
            this.LabelFrom.Visible = false;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(76, 131);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Visible = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // TextBoxDistance
            // 
            this.TextBoxDistance.Location = new System.Drawing.Point(135, 86);
            this.TextBoxDistance.Name = "TextBoxDistance";
            this.TextBoxDistance.Size = new System.Drawing.Size(93, 23);
            this.TextBoxDistance.TabIndex = 3;
            this.TextBoxDistance.Visible = false;
            // 
            // ComboBoxDirection
            // 
            this.ComboBoxDirection.FormattingEnabled = true;
            this.ComboBoxDirection.Items.AddRange(new object[] {
            "Directed",
            "Undirected"});
            this.ComboBoxDirection.Location = new System.Drawing.Point(17, 86);
            this.ComboBoxDirection.Name = "ComboBoxDirection";
            this.ComboBoxDirection.Size = new System.Drawing.Size(86, 23);
            this.ComboBoxDirection.TabIndex = 2;
            this.ComboBoxDirection.Visible = false;
            // 
            // ComboBoxToDatapoints
            // 
            this.ComboBoxToDatapoints.FormattingEnabled = true;
            this.ComboBoxToDatapoints.Location = new System.Drawing.Point(135, 29);
            this.ComboBoxToDatapoints.Name = "ComboBoxToDatapoints";
            this.ComboBoxToDatapoints.Size = new System.Drawing.Size(93, 23);
            this.ComboBoxToDatapoints.TabIndex = 1;
            this.ComboBoxToDatapoints.Visible = false;
            this.ComboBoxToDatapoints.SelectedIndexChanged += new System.EventHandler(this.ComboBoxToDatapoints_SelectedIndexChanged);
            // 
            // ComboBoxFromDatapoints
            // 
            this.ComboBoxFromDatapoints.FormattingEnabled = true;
            this.ComboBoxFromDatapoints.Location = new System.Drawing.Point(17, 29);
            this.ComboBoxFromDatapoints.Name = "ComboBoxFromDatapoints";
            this.ComboBoxFromDatapoints.Size = new System.Drawing.Size(86, 23);
            this.ComboBoxFromDatapoints.TabIndex = 0;
            this.ComboBoxFromDatapoints.Visible = false;
            this.ComboBoxFromDatapoints.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFromDatapoints_SelectedIndexChanged);
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
            this.MenuItemFileSaveAs,
            this.commitToolStripMenuItem});
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
            this.MenuItemFileScene.Size = new System.Drawing.Size(180, 22);
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
            this.MenuItemFileSave.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileSave.Text = "Save";
            this.MenuItemFileSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileOpen.Text = "Open";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MenuItemFileSaveAs
            // 
            this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
            this.MenuItemFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileSaveAs.Text = "Save as";
            this.MenuItemFileSaveAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // commitToolStripMenuItem
            // 
            this.commitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCommitSceneDatapoints,
            this.MenuItemCommitAllDatapoints});
            this.commitToolStripMenuItem.Name = "commitToolStripMenuItem";
            this.commitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commitToolStripMenuItem.Text = "Commit";
            // 
            // MenuItemCommitSceneDatapoints
            // 
            this.MenuItemCommitSceneDatapoints.Name = "MenuItemCommitSceneDatapoints";
            this.MenuItemCommitSceneDatapoints.Size = new System.Drawing.Size(165, 22);
            this.MenuItemCommitSceneDatapoints.Text = "Scene Datapoints";
            this.MenuItemCommitSceneDatapoints.Click += new System.EventHandler(this.MenuItemCommitSceneDatapoints_Click);
            // 
            // MenuItemCommitAllDatapoints
            // 
            this.MenuItemCommitAllDatapoints.Name = "MenuItemCommitAllDatapoints";
            this.MenuItemCommitAllDatapoints.Size = new System.Drawing.Size(165, 22);
            this.MenuItemCommitAllDatapoints.Text = "All Datapoints";
            this.MenuItemCommitAllDatapoints.Click += new System.EventHandler(this.MenuItemCommitAllDatapoints_Click);
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
            this.undoCommitToolStripMenuItem});
            this.MenuItemDatapoints.Name = "MenuItemDatapoints";
            this.MenuItemDatapoints.Size = new System.Drawing.Size(76, 20);
            this.MenuItemDatapoints.Text = "Datapoints";
            // 
            // MenuItemAddDatapoint
            // 
            this.MenuItemAddDatapoint.Name = "MenuItemAddDatapoint";
            this.MenuItemAddDatapoint.Size = new System.Drawing.Size(180, 22);
            this.MenuItemAddDatapoint.Text = "Add";
            this.MenuItemAddDatapoint.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // MenuItemDatapointsRemove
            // 
            this.MenuItemDatapointsRemove.Name = "MenuItemDatapointsRemove";
            this.MenuItemDatapointsRemove.Size = new System.Drawing.Size(180, 22);
            this.MenuItemDatapointsRemove.Text = "Remove";
            this.MenuItemDatapointsRemove.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // MenuItemConnectDatapoint
            // 
            this.MenuItemConnectDatapoint.Name = "MenuItemConnectDatapoint";
            this.MenuItemConnectDatapoint.Size = new System.Drawing.Size(180, 22);
            this.MenuItemConnectDatapoint.Text = "Connect";
            this.MenuItemConnectDatapoint.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // undoCommitToolStripMenuItem
            // 
            this.undoCommitToolStripMenuItem.Name = "undoCommitToolStripMenuItem";
            this.undoCommitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoCommitToolStripMenuItem.Text = "Undo Commit";
            this.undoCommitToolStripMenuItem.Click += new System.EventHandler(this.undoCommitToolStripMenuItem_Click);
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
            this.PanelAllListBox.ResumeLayout(false);
            this.PanelAuxButton.ResumeLayout(false);
            this.PanelAuxButton.PerformLayout();
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
        private PictureBox PictureBoxSceneImage;
        private ToolStripMenuItem MenuItemDatapoints;
        private ToolStripMenuItem MenuItemAddDatapoint;
        private ToolStripMenuItem MenuItemDatapointsRemove;
        private ToolStripMenuItem MenuItemConnectDatapoint;
        private ToolStripMenuItem MenuItemFileSceneView;
        private Panel PanelAllListBox;
        private ListBox ListBoxScenes;
        private ListBox ListBoxDatapoints;
        private Panel PanelAuxButton;
        private ComboBox ComboBoxFromDatapoints;
        private Label LabelDistance;
        private Label LabelDirection;
        private Label LabelTo;
        private Label LabelFrom;
        private Button ButtonConnect;
        private TextBox TextBoxDistance;
        private ComboBox ComboBoxDirection;
        private ComboBox ComboBoxToDatapoints;
        private ToolStripMenuItem commitToolStripMenuItem;
        private ToolStripMenuItem MenuItemCommitSceneDatapoints;
        private ToolStripMenuItem MenuItemCommitAllDatapoints;
        private ToolStripMenuItem undoCommitToolStripMenuItem;
    }
}