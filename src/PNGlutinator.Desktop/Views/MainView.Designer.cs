namespace PNGlutinator
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForum = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputDirectoryBrowseButton = new System.Windows.Forms.Button();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.outputDirectoryLabel = new System.Windows.Forms.Label();
            this.overwriteIfLargerCheckBox = new System.Windows.Forms.CheckBox();
            this.overwriteCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colourSettingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pngTypeComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.addFilesButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fileBatchDataGridView = new System.Windows.Forms.DataGridView();
            this.FileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealFileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptimisedSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.fileListContextMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileBatchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbout,
            this.toolStripButtonHelp,
            this.toolStripButtonCustomize,
            this.toolStripButtonForum});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButtonAbout, "toolStripButtonAbout");
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButtonHelp, "toolStripButtonHelp");
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // toolStripButtonCustomize
            // 
            this.toolStripButtonCustomize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButtonCustomize, "toolStripButtonCustomize");
            this.toolStripButtonCustomize.Name = "toolStripButtonCustomize";
            this.toolStripButtonCustomize.Click += new System.EventHandler(this.toolStripButtonCustomize_Click);
            // 
            // toolStripButtonForum
            // 
            this.toolStripButtonForum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButtonForum, "toolStripButtonForum");
            this.toolStripButtonForum.Name = "toolStripButtonForum";
            this.toolStripButtonForum.Click += new System.EventHandler(this.toolStripButtonForum_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.outputDirectoryBrowseButton);
            this.groupBox1.Controls.Add(this.outputDirectoryTextBox);
            this.groupBox1.Controls.Add(this.outputDirectoryLabel);
            this.groupBox1.Controls.Add(this.overwriteIfLargerCheckBox);
            this.groupBox1.Controls.Add(this.overwriteCheckBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // outputDirectoryBrowseButton
            // 
            resources.ApplyResources(this.outputDirectoryBrowseButton, "outputDirectoryBrowseButton");
            this.outputDirectoryBrowseButton.Name = "outputDirectoryBrowseButton";
            this.outputDirectoryBrowseButton.UseVisualStyleBackColor = true;
            this.outputDirectoryBrowseButton.Click += new System.EventHandler(this.outputDirectoryBrowseButton_Click);
            // 
            // outputDirectoryTextBox
            // 
            resources.ApplyResources(this.outputDirectoryTextBox, "outputDirectoryTextBox");
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            // 
            // outputDirectoryLabel
            // 
            resources.ApplyResources(this.outputDirectoryLabel, "outputDirectoryLabel");
            this.outputDirectoryLabel.Name = "outputDirectoryLabel";
            // 
            // overwriteIfLargerCheckBox
            // 
            resources.ApplyResources(this.overwriteIfLargerCheckBox, "overwriteIfLargerCheckBox");
            this.overwriteIfLargerCheckBox.Name = "overwriteIfLargerCheckBox";
            this.overwriteIfLargerCheckBox.UseVisualStyleBackColor = true;
            // 
            // overwriteCheckBox
            // 
            resources.ApplyResources(this.overwriteCheckBox, "overwriteCheckBox");
            this.overwriteCheckBox.Name = "overwriteCheckBox";
            this.overwriteCheckBox.UseVisualStyleBackColor = true;
            this.overwriteCheckBox.CheckedChanged += new System.EventHandler(this.overwriteCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.colourSettingsButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pngTypeComboBox);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // colourSettingsButton
            // 
            resources.ApplyResources(this.colourSettingsButton, "colourSettingsButton");
            this.colourSettingsButton.Name = "colourSettingsButton";
            this.colourSettingsButton.UseVisualStyleBackColor = true;
            this.colourSettingsButton.Click += new System.EventHandler(this.colourSettingsButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pngTypeComboBox
            // 
            resources.ApplyResources(this.pngTypeComboBox, "pngTypeComboBox");
            this.pngTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pngTypeComboBox.Name = "pngTypeComboBox";
            this.pngTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.pngTypeComboBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusText});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            resources.ApplyResources(this.progressBar, "progressBar");
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            resources.ApplyResources(this.statusText, "statusText");
            // 
            // fileListContextMenu
            // 
            this.fileListContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fileListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteMenuItem});
            this.fileListContextMenu.Name = "fileListContextMenu";
            resources.ApplyResources(this.fileListContextMenu, "fileListContextMenu");
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            resources.ApplyResources(this.pasteMenuItem, "pasteMenuItem");
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // addFilesDialog
            // 
            this.addFilesDialog.DefaultExt = "png";
            this.addFilesDialog.Multiselect = true;
            resources.ApplyResources(this.addFilesDialog, "addFilesDialog");
            // 
            // outputFolderBrowserDialog
            // 
            resources.ApplyResources(this.outputFolderBrowserDialog, "outputFolderBrowserDialog");
            this.outputFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cancelButton);
            this.groupBox3.Controls.Add(this.goButton);
            this.groupBox3.Controls.Add(this.removeItemButton);
            this.groupBox3.Controls.Add(this.addFilesButton);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // goButton
            // 
            resources.ApplyResources(this.goButton, "goButton");
            this.goButton.Name = "goButton";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // removeItemButton
            // 
            resources.ApplyResources(this.removeItemButton, "removeItemButton");
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // addFilesButton
            // 
            resources.ApplyResources(this.addFilesButton, "addFilesButton");
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.UseVisualStyleBackColor = true;
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fileBatchDataGridView);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // fileBatchDataGridView
            // 
            this.fileBatchDataGridView.AllowUserToAddRows = false;
            this.fileBatchDataGridView.AllowUserToOrderColumns = true;
            this.fileBatchDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.fileBatchDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fileBatchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileBatchDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.fileBatchDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.fileBatchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileBatchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileColumn,
            this.RealFileColumn,
            this.OriginalSizeColumn,
            this.OptimisedSizeColumn,
            this.Percent,
            this.StatusColumn});
            this.fileBatchDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.fileBatchDataGridView, "fileBatchDataGridView");
            this.fileBatchDataGridView.Name = "fileBatchDataGridView";
            this.fileBatchDataGridView.ReadOnly = true;
            this.fileBatchDataGridView.RowHeadersVisible = false;
            this.fileBatchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // FileColumn
            // 
            this.FileColumn.FillWeight = 237.3096F;
            resources.ApplyResources(this.FileColumn, "FileColumn");
            this.FileColumn.Name = "FileColumn";
            this.FileColumn.ReadOnly = true;
            // 
            // RealFileColumn
            // 
            resources.ApplyResources(this.RealFileColumn, "RealFileColumn");
            this.RealFileColumn.Name = "RealFileColumn";
            this.RealFileColumn.ReadOnly = true;
            // 
            // OriginalSizeColumn
            // 
            this.OriginalSizeColumn.FillWeight = 59.32741F;
            resources.ApplyResources(this.OriginalSizeColumn, "OriginalSizeColumn");
            this.OriginalSizeColumn.Name = "OriginalSizeColumn";
            this.OriginalSizeColumn.ReadOnly = true;
            // 
            // OptimisedSizeColumn
            // 
            this.OptimisedSizeColumn.FillWeight = 59.32741F;
            resources.ApplyResources(this.OptimisedSizeColumn, "OptimisedSizeColumn");
            this.OptimisedSizeColumn.Name = "OptimisedSizeColumn";
            this.OptimisedSizeColumn.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.FillWeight = 25.38071F;
            resources.ApplyResources(this.Percent, "Percent");
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.FillWeight = 118.6548F;
            resources.ApplyResources(this.StatusColumn, "StatusColumn");
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // MainView
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainView";
            this.Activated += new System.EventHandler(this.MainView_Activated);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainView_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainView_DragEnter);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.fileListContextMenu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileBatchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button outputDirectoryBrowseButton;
        private System.Windows.Forms.TextBox outputDirectoryTextBox;
        private System.Windows.Forms.Label outputDirectoryLabel;
        private System.Windows.Forms.CheckBox overwriteIfLargerCheckBox;
        private System.Windows.Forms.CheckBox overwriteCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pngTypeComboBox;
        private System.Windows.Forms.Button colourSettingsButton;
        private System.Windows.Forms.OpenFileDialog addFilesDialog;
        private System.Windows.Forms.ContextMenuStrip fileListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        public System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button addFilesButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.ToolStripButton toolStripButtonCustomize;
        private System.Windows.Forms.ToolStripButton toolStripButtonForum;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView fileBatchDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealFileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptimisedSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}

