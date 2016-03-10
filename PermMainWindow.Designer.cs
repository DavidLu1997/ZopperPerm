namespace ZopperPerm
{
    partial class PermMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermMainWindow));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.stringToPermute = new System.Windows.Forms.TextBox();
            this.permutationButton = new System.Windows.Forms.RadioButton();
            this.combinationButton = new System.Windows.Forms.RadioButton();
            this.kValue = new System.Windows.Forms.NumericUpDown();
            this.mainOutput = new System.Windows.Forms.RichTextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.fileOutput = new System.Windows.Forms.CheckBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.kValue)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Step = 1;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // stringToPermute
            // 
            resources.ApplyResources(this.stringToPermute, "stringToPermute");
            this.stringToPermute.Name = "stringToPermute";
            this.stringToPermute.ShortcutsEnabled = false;
            this.stringToPermute.TextChanged += new System.EventHandler(this.changeK);
            // 
            // permutationButton
            // 
            resources.ApplyResources(this.permutationButton, "permutationButton");
            this.permutationButton.Name = "permutationButton";
            this.permutationButton.TabStop = true;
            this.permutationButton.UseVisualStyleBackColor = true;
            this.permutationButton.Click += new System.EventHandler(this.updateRadioButtons);
            // 
            // combinationButton
            // 
            resources.ApplyResources(this.combinationButton, "combinationButton");
            this.combinationButton.Name = "combinationButton";
            this.combinationButton.TabStop = true;
            this.combinationButton.UseVisualStyleBackColor = true;
            this.combinationButton.Click += new System.EventHandler(this.updateRadioButtons);
            // 
            // kValue
            // 
            resources.ApplyResources(this.kValue, "kValue");
            this.kValue.Name = "kValue";
            this.kValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kValue.ValueChanged += new System.EventHandler(this.changeKValue);
            // 
            // mainOutput
            // 
            resources.ApplyResources(this.mainOutput, "mainOutput");
            this.mainOutput.Name = "mainOutput";
            // 
            // generateButton
            // 
            resources.ApplyResources(this.generateButton, "generateButton");
            this.generateButton.Name = "generateButton";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateAction);
            // 
            // total
            // 
            resources.ApplyResources(this.total, "total");
            this.total.Name = "total";
            // 
            // fileOutput
            // 
            resources.ApplyResources(this.fileOutput, "fileOutput");
            this.fileOutput.Name = "fileOutput";
            this.fileOutput.UseVisualStyleBackColor = true;
            this.fileOutput.CheckedChanged += new System.EventHandler(this.fileOutput_CheckedChanged);
            // 
            // fileName
            // 
            resources.ApplyResources(this.fileName, "fileName");
            this.fileName.Name = "fileName";
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PermMainWindow
            // 
            this.AcceptButton = this.generateButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileOutput);
            this.Controls.Add(this.total);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.mainOutput);
            this.Controls.Add(this.kValue);
            this.Controls.Add(this.combinationButton);
            this.Controls.Add(this.permutationButton);
            this.Controls.Add(this.stringToPermute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PermMainWindow";
            this.Load += new System.EventHandler(this.PermMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kValue)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stringToPermute;
        private System.Windows.Forms.RadioButton permutationButton;
        private System.Windows.Forms.RadioButton combinationButton;
        private System.Windows.Forms.NumericUpDown kValue;
        private System.Windows.Forms.RichTextBox mainOutput;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.CheckBox fileOutput;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

