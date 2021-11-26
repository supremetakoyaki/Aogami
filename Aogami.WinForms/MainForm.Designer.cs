namespace Aogami.WinForms
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
            this.components = new System.ComponentModel.Container();
            this.OpenSaveFileButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.SaveDataTabControl = new System.Windows.Forms.TabControl();
            this.GeneralStatsTabPage = new System.Windows.Forms.TabPage();
            this.MaccaNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaccaLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.DebugTestsButton = new System.Windows.Forms.Button();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.SaveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.MakeBackUpCheckbox = new System.Windows.Forms.CheckBox();
            this.ImportDecryptedDataButton = new System.Windows.Forms.Button();
            this.ExportDecryptedDataButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SaveDataTabControl.SuspendLayout();
            this.GeneralStatsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaccaNumUpDown)).BeginInit();
            this.SaveDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenSaveFileButton
            // 
            this.OpenSaveFileButton.Location = new System.Drawing.Point(168, 12);
            this.OpenSaveFileButton.Name = "OpenSaveFileButton";
            this.OpenSaveFileButton.Size = new System.Drawing.Size(144, 60);
            this.OpenSaveFileButton.TabIndex = 0;
            this.OpenSaveFileButton.Text = "Open Save File...";
            this.OpenSaveFileButton.UseVisualStyleBackColor = true;
            this.OpenSaveFileButton.Click += new System.EventHandler(this.OpenSaveFileButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(150, 60);
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.Honeydew;
            this.SaveChangesButton.Enabled = false;
            this.SaveChangesButton.Location = new System.Drawing.Point(318, 12);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(111, 33);
            this.SaveChangesButton.TabIndex = 2;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // SaveDataTabControl
            // 
            this.SaveDataTabControl.Controls.Add(this.GeneralStatsTabPage);
            this.SaveDataTabControl.Controls.Add(this.ItemsTabPage);
            this.SaveDataTabControl.Location = new System.Drawing.Point(6, 22);
            this.SaveDataTabControl.Name = "SaveDataTabControl";
            this.SaveDataTabControl.SelectedIndex = 0;
            this.SaveDataTabControl.Size = new System.Drawing.Size(548, 259);
            this.SaveDataTabControl.TabIndex = 3;
            // 
            // GeneralStatsTabPage
            // 
            this.GeneralStatsTabPage.Controls.Add(this.MaccaNumUpDown);
            this.GeneralStatsTabPage.Controls.Add(this.MaccaLabel);
            this.GeneralStatsTabPage.Controls.Add(this.LastNameTextBox);
            this.GeneralStatsTabPage.Controls.Add(this.FirstNameTextBox);
            this.GeneralStatsTabPage.Controls.Add(this.LastNameLabel);
            this.GeneralStatsTabPage.Controls.Add(this.FirstNameLabel);
            this.GeneralStatsTabPage.Controls.Add(this.DebugTestsButton);
            this.GeneralStatsTabPage.Location = new System.Drawing.Point(4, 24);
            this.GeneralStatsTabPage.Name = "GeneralStatsTabPage";
            this.GeneralStatsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralStatsTabPage.Size = new System.Drawing.Size(540, 231);
            this.GeneralStatsTabPage.TabIndex = 0;
            this.GeneralStatsTabPage.Text = "General";
            this.GeneralStatsTabPage.UseVisualStyleBackColor = true;
            // 
            // MaccaNumUpDown
            // 
            this.MaccaNumUpDown.Location = new System.Drawing.Point(78, 69);
            this.MaccaNumUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MaccaNumUpDown.Name = "MaccaNumUpDown";
            this.MaccaNumUpDown.Size = new System.Drawing.Size(90, 23);
            this.MaccaNumUpDown.TabIndex = 6;
            this.MaccaNumUpDown.ValueChanged += new System.EventHandler(this.MaccaNumUpDown_ValueChanged);
            // 
            // MaccaLabel
            // 
            this.MaccaLabel.AutoSize = true;
            this.MaccaLabel.Location = new System.Drawing.Point(6, 71);
            this.MaccaLabel.Name = "MaccaLabel";
            this.MaccaLabel.Size = new System.Drawing.Size(45, 15);
            this.MaccaLabel.TabIndex = 5;
            this.MaccaLabel.Text = "Macca:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(78, 40);
            this.LastNameTextBox.MaxLength = 8;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(90, 23);
            this.LastNameTextBox.TabIndex = 4;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(78, 11);
            this.FirstNameTextBox.MaxLength = 8;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(90, 23);
            this.FirstNameTextBox.TabIndex = 3;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(6, 43);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(66, 15);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 14);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // DebugTestsButton
            // 
            this.DebugTestsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DebugTestsButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.DebugTestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DebugTestsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DebugTestsButton.Location = new System.Drawing.Point(459, 196);
            this.DebugTestsButton.Name = "DebugTestsButton";
            this.DebugTestsButton.Size = new System.Drawing.Size(75, 29);
            this.DebugTestsButton.TabIndex = 0;
            this.DebugTestsButton.Text = "Test";
            this.DebugTestsButton.UseVisualStyleBackColor = false;
            this.DebugTestsButton.Visible = false;
            this.DebugTestsButton.Click += new System.EventHandler(this.DebugTestsButton_Click);
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(540, 231);
            this.ItemsTabPage.TabIndex = 1;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveDataGroupBox
            // 
            this.SaveDataGroupBox.Controls.Add(this.SaveDataTabControl);
            this.SaveDataGroupBox.Location = new System.Drawing.Point(12, 78);
            this.SaveDataGroupBox.Name = "SaveDataGroupBox";
            this.SaveDataGroupBox.Size = new System.Drawing.Size(560, 287);
            this.SaveDataGroupBox.TabIndex = 4;
            this.SaveDataGroupBox.TabStop = false;
            this.SaveDataGroupBox.Text = "Save Data";
            // 
            // MakeBackUpCheckbox
            // 
            this.MakeBackUpCheckbox.AutoSize = true;
            this.MakeBackUpCheckbox.Location = new System.Drawing.Point(318, 51);
            this.MakeBackUpCheckbox.Name = "MakeBackUpCheckbox";
            this.MakeBackUpCheckbox.Size = new System.Drawing.Size(111, 19);
            this.MakeBackUpCheckbox.TabIndex = 5;
            this.MakeBackUpCheckbox.Text = "Make a back-up";
            this.MakeBackUpCheckbox.UseVisualStyleBackColor = true;
            // 
            // ImportDecryptedDataButton
            // 
            this.ImportDecryptedDataButton.Location = new System.Drawing.Point(435, 12);
            this.ImportDecryptedDataButton.Name = "ImportDecryptedDataButton";
            this.ImportDecryptedDataButton.Size = new System.Drawing.Size(137, 27);
            this.ImportDecryptedDataButton.TabIndex = 6;
            this.ImportDecryptedDataButton.Text = "Import Decrypted Data";
            this.ImportDecryptedDataButton.UseVisualStyleBackColor = true;
            this.ImportDecryptedDataButton.Click += new System.EventHandler(this.ImportDecryptedDataButton_Click);
            // 
            // ExportDecryptedDataButton
            // 
            this.ExportDecryptedDataButton.Location = new System.Drawing.Point(435, 45);
            this.ExportDecryptedDataButton.Name = "ExportDecryptedDataButton";
            this.ExportDecryptedDataButton.Size = new System.Drawing.Size(137, 27);
            this.ExportDecryptedDataButton.TabIndex = 7;
            this.ExportDecryptedDataButton.Text = "Export Decrypted Data";
            this.ExportDecryptedDataButton.UseVisualStyleBackColor = true;
            this.ExportDecryptedDataButton.Click += new System.EventHandler(this.ExportDecryptedDataButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.ExportDecryptedDataButton);
            this.Controls.Add(this.ImportDecryptedDataButton);
            this.Controls.Add(this.MakeBackUpCheckbox);
            this.Controls.Add(this.SaveDataGroupBox);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.OpenSaveFileButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Aogami";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.SaveDataTabControl.ResumeLayout(false);
            this.GeneralStatsTabPage.ResumeLayout(false);
            this.GeneralStatsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaccaNumUpDown)).EndInit();
            this.SaveDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OpenSaveFileButton;
        private PictureBox LogoPictureBox;
        private Button SaveChangesButton;
        private TabControl SaveDataTabControl;
        private TabPage GeneralStatsTabPage;
        private TabPage ItemsTabPage;
        private GroupBox SaveDataGroupBox;
        private CheckBox MakeBackUpCheckbox;
        private Button ImportDecryptedDataButton;
        private Button ExportDecryptedDataButton;
        private Button DebugTestsButton;
        private ImageList imageList1;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private NumericUpDown MaccaNumUpDown;
        private Label MaccaLabel;
    }
}