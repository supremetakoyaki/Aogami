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
            this.OpenSaveFileButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.SaveDataTabControl = new System.Windows.Forms.TabControl();
            this.GeneralStatsTabPage = new System.Windows.Forms.TabPage();
            this.DifficultyComboBox = new System.Windows.Forms.ComboBox();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.DateSavedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateSavedLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.PlayTimeMinutesNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.PlayTimeHoursNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.PlayTimeLabel = new System.Windows.Forms.Label();
            this.GloryNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.GloryLabel = new System.Windows.Forms.Label();
            this.MaccaNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaccaLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.DebugTestsButton = new System.Windows.Forms.Button();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsShowUnusedCheckBox = new System.Windows.Forms.CheckBox();
            this.ItemsSetAllTo99Button = new System.Windows.Forms.Button();
            this.ItemsSetAllTo255Button = new System.Windows.Forms.Button();
            this.ItemListDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NahobinoTabPage = new System.Windows.Forms.TabPage();
            this.SetNahobinoToMaxButton = new System.Windows.Forms.Button();
            this.LuckNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.LuckLabel = new System.Windows.Forms.Label();
            this.AgilityNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.MagicNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.MagicLabel = new System.Windows.Forms.Label();
            this.VitalityNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.VitalityLabel = new System.Windows.Forms.Label();
            this.StrengthNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.NahobinoMpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NahobinoMpLabel = new System.Windows.Forms.Label();
            this.NahobinoHpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NahobinoHpLabel = new System.Windows.Forms.Label();
            this.NahobinoExperienceNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.NahobinoLevelNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.NahobinoExperienceLabel = new System.Windows.Forms.Label();
            this.NahobinoLevelLabel = new System.Windows.Forms.Label();
            this.SaveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.MakeBackUpCheckbox = new System.Windows.Forms.CheckBox();
            this.ImportDecryptedDataButton = new System.Windows.Forms.Button();
            this.ExportDecryptedDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SaveDataTabControl.SuspendLayout();
            this.GeneralStatsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayTimeMinutesNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayTimeHoursNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloryNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaccaNumUpDown)).BeginInit();
            this.ItemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemListDataGridView)).BeginInit();
            this.NahobinoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuckNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgilityNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VitalityNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NahobinoMpNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NahobinoHpNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NahobinoExperienceNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NahobinoLevelNumUpDown)).BeginInit();
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
            this.SaveDataTabControl.Controls.Add(this.NahobinoTabPage);
            this.SaveDataTabControl.Location = new System.Drawing.Point(6, 22);
            this.SaveDataTabControl.Name = "SaveDataTabControl";
            this.SaveDataTabControl.SelectedIndex = 0;
            this.SaveDataTabControl.Size = new System.Drawing.Size(548, 259);
            this.SaveDataTabControl.TabIndex = 3;
            // 
            // GeneralStatsTabPage
            // 
            this.GeneralStatsTabPage.Controls.Add(this.DifficultyComboBox);
            this.GeneralStatsTabPage.Controls.Add(this.DifficultyLabel);
            this.GeneralStatsTabPage.Controls.Add(this.DateSavedDateTimePicker);
            this.GeneralStatsTabPage.Controls.Add(this.DateSavedLabel);
            this.GeneralStatsTabPage.Controls.Add(this.MinutesLabel);
            this.GeneralStatsTabPage.Controls.Add(this.PlayTimeMinutesNumUpDown);
            this.GeneralStatsTabPage.Controls.Add(this.HoursLabel);
            this.GeneralStatsTabPage.Controls.Add(this.PlayTimeHoursNumUpDown);
            this.GeneralStatsTabPage.Controls.Add(this.PlayTimeLabel);
            this.GeneralStatsTabPage.Controls.Add(this.GloryNumUpDown);
            this.GeneralStatsTabPage.Controls.Add(this.GloryLabel);
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
            // DifficultyComboBox
            // 
            this.DifficultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyComboBox.FormattingEnabled = true;
            this.DifficultyComboBox.Items.AddRange(new object[] {
            "Safety",
            "Casual",
            "Normal",
            "Hard"});
            this.DifficultyComboBox.Location = new System.Drawing.Point(303, 69);
            this.DifficultyComboBox.Name = "DifficultyComboBox";
            this.DifficultyComboBox.Size = new System.Drawing.Size(82, 23);
            this.DifficultyComboBox.TabIndex = 17;
            this.DifficultyComboBox.SelectedIndexChanged += new System.EventHandler(this.DifficultyComboBox_SelectedIndexChanged);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Location = new System.Drawing.Point(229, 71);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(58, 15);
            this.DifficultyLabel.TabIndex = 16;
            this.DifficultyLabel.Text = "Difficulty:";
            // 
            // DateSavedDateTimePicker
            // 
            this.DateSavedDateTimePicker.CustomFormat = "MMMM dd\',\' yyyy \'at\' h\':\'mm tt";
            this.DateSavedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateSavedDateTimePicker.Location = new System.Drawing.Point(303, 40);
            this.DateSavedDateTimePicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.DateSavedDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateSavedDateTimePicker.Name = "DateSavedDateTimePicker";
            this.DateSavedDateTimePicker.Size = new System.Drawing.Size(231, 23);
            this.DateSavedDateTimePicker.TabIndex = 15;
            this.DateSavedDateTimePicker.ValueChanged += new System.EventHandler(this.DateSavedDateTimePicker_ValueChanged);
            // 
            // DateSavedLabel
            // 
            this.DateSavedLabel.AutoSize = true;
            this.DateSavedLabel.Location = new System.Drawing.Point(229, 43);
            this.DateSavedLabel.Name = "DateSavedLabel";
            this.DateSavedLabel.Size = new System.Drawing.Size(68, 15);
            this.DateSavedLabel.TabIndex = 14;
            this.DateSavedLabel.Text = "Date Saved:";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(459, 14);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(33, 15);
            this.MinutesLabel.TabIndex = 13;
            this.MinutesLabel.Text = "mins";
            // 
            // PlayTimeMinutesNumUpDown
            // 
            this.PlayTimeMinutesNumUpDown.Location = new System.Drawing.Point(400, 11);
            this.PlayTimeMinutesNumUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.PlayTimeMinutesNumUpDown.Name = "PlayTimeMinutesNumUpDown";
            this.PlayTimeMinutesNumUpDown.Size = new System.Drawing.Size(53, 23);
            this.PlayTimeMinutesNumUpDown.TabIndex = 12;
            this.PlayTimeMinutesNumUpDown.ValueChanged += new System.EventHandler(this.PlayTimeMinutesNumUpDown_ValueChanged);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(362, 14);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(23, 15);
            this.HoursLabel.TabIndex = 11;
            this.HoursLabel.Text = "hrs";
            // 
            // PlayTimeHoursNumUpDown
            // 
            this.PlayTimeHoursNumUpDown.Location = new System.Drawing.Point(303, 11);
            this.PlayTimeHoursNumUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PlayTimeHoursNumUpDown.Name = "PlayTimeHoursNumUpDown";
            this.PlayTimeHoursNumUpDown.Size = new System.Drawing.Size(53, 23);
            this.PlayTimeHoursNumUpDown.TabIndex = 10;
            this.PlayTimeHoursNumUpDown.ValueChanged += new System.EventHandler(this.PlayTimeHoursNumUpDown_ValueChanged);
            // 
            // PlayTimeLabel
            // 
            this.PlayTimeLabel.AutoSize = true;
            this.PlayTimeLabel.Location = new System.Drawing.Point(229, 14);
            this.PlayTimeLabel.Name = "PlayTimeLabel";
            this.PlayTimeLabel.Size = new System.Drawing.Size(61, 15);
            this.PlayTimeLabel.TabIndex = 9;
            this.PlayTimeLabel.Text = "Play Time:";
            // 
            // GloryNumUpDown
            // 
            this.GloryNumUpDown.Location = new System.Drawing.Point(78, 98);
            this.GloryNumUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.GloryNumUpDown.Name = "GloryNumUpDown";
            this.GloryNumUpDown.Size = new System.Drawing.Size(90, 23);
            this.GloryNumUpDown.TabIndex = 8;
            this.GloryNumUpDown.ValueChanged += new System.EventHandler(this.GloryNumUpDown_ValueChanged);
            // 
            // GloryLabel
            // 
            this.GloryLabel.AutoSize = true;
            this.GloryLabel.Location = new System.Drawing.Point(6, 100);
            this.GloryLabel.Name = "GloryLabel";
            this.GloryLabel.Size = new System.Drawing.Size(38, 15);
            this.GloryLabel.TabIndex = 7;
            this.GloryLabel.Text = "Glory:";
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
            this.ItemsTabPage.Controls.Add(this.ItemsShowUnusedCheckBox);
            this.ItemsTabPage.Controls.Add(this.ItemsSetAllTo99Button);
            this.ItemsTabPage.Controls.Add(this.ItemsSetAllTo255Button);
            this.ItemsTabPage.Controls.Add(this.ItemListDataGridView);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 24);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(540, 231);
            this.ItemsTabPage.TabIndex = 1;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsShowUnusedCheckBox
            // 
            this.ItemsShowUnusedCheckBox.AutoSize = true;
            this.ItemsShowUnusedCheckBox.Location = new System.Drawing.Point(6, 205);
            this.ItemsShowUnusedCheckBox.Name = "ItemsShowUnusedCheckBox";
            this.ItemsShowUnusedCheckBox.Size = new System.Drawing.Size(129, 19);
            this.ItemsShowUnusedCheckBox.TabIndex = 3;
            this.ItemsShowUnusedCheckBox.Text = "Show unused items";
            this.ItemsShowUnusedCheckBox.UseVisualStyleBackColor = true;
            this.ItemsShowUnusedCheckBox.CheckedChanged += new System.EventHandler(this.ItemsShowUnusedCheckBox_CheckedChanged);
            // 
            // ItemsSetAllTo99Button
            // 
            this.ItemsSetAllTo99Button.BackColor = System.Drawing.Color.MintCream;
            this.ItemsSetAllTo99Button.Location = new System.Drawing.Point(328, 202);
            this.ItemsSetAllTo99Button.Name = "ItemsSetAllTo99Button";
            this.ItemsSetAllTo99Button.Size = new System.Drawing.Size(100, 23);
            this.ItemsSetAllTo99Button.TabIndex = 2;
            this.ItemsSetAllTo99Button.Text = "Set All To 99";
            this.ItemsSetAllTo99Button.UseVisualStyleBackColor = false;
            this.ItemsSetAllTo99Button.Click += new System.EventHandler(this.ItemsSetAllTo99Button_Click);
            // 
            // ItemsSetAllTo255Button
            // 
            this.ItemsSetAllTo255Button.BackColor = System.Drawing.Color.Ivory;
            this.ItemsSetAllTo255Button.Location = new System.Drawing.Point(434, 202);
            this.ItemsSetAllTo255Button.Name = "ItemsSetAllTo255Button";
            this.ItemsSetAllTo255Button.Size = new System.Drawing.Size(100, 23);
            this.ItemsSetAllTo255Button.TabIndex = 1;
            this.ItemsSetAllTo255Button.Text = "Set All To 255";
            this.ItemsSetAllTo255Button.UseVisualStyleBackColor = false;
            this.ItemsSetAllTo255Button.Click += new System.EventHandler(this.ItemsSetAllTo255Button_Click);
            // 
            // ItemListDataGridView
            // 
            this.ItemListDataGridView.AllowUserToAddRows = false;
            this.ItemListDataGridView.AllowUserToDeleteRows = false;
            this.ItemListDataGridView.AllowUserToResizeColumns = false;
            this.ItemListDataGridView.AllowUserToResizeRows = false;
            this.ItemListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemIndexColumn,
            this.ItemNameColumn,
            this.ItemTypeColumn,
            this.ItemAmountColumn});
            this.ItemListDataGridView.Location = new System.Drawing.Point(6, 6);
            this.ItemListDataGridView.MultiSelect = false;
            this.ItemListDataGridView.Name = "ItemListDataGridView";
            this.ItemListDataGridView.RowHeadersVisible = false;
            this.ItemListDataGridView.RowTemplate.Height = 25;
            this.ItemListDataGridView.ShowEditingIcon = false;
            this.ItemListDataGridView.Size = new System.Drawing.Size(528, 190);
            this.ItemListDataGridView.TabIndex = 0;
            this.ItemListDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemListDataGridView_CellValueChanged);
            this.ItemListDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ItemListDataGridView_EditingControlShowing);
            // 
            // ItemIndexColumn
            // 
            this.ItemIndexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemIndexColumn.FillWeight = 25F;
            this.ItemIndexColumn.HeaderText = "Index";
            this.ItemIndexColumn.MinimumWidth = 10;
            this.ItemIndexColumn.Name = "ItemIndexColumn";
            // 
            // ItemNameColumn
            // 
            this.ItemNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemNameColumn.HeaderText = "Name";
            this.ItemNameColumn.MinimumWidth = 50;
            this.ItemNameColumn.Name = "ItemNameColumn";
            this.ItemNameColumn.ReadOnly = true;
            // 
            // ItemTypeColumn
            // 
            this.ItemTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemTypeColumn.FillWeight = 60F;
            this.ItemTypeColumn.HeaderText = "Type";
            this.ItemTypeColumn.MinimumWidth = 25;
            this.ItemTypeColumn.Name = "ItemTypeColumn";
            this.ItemTypeColumn.ReadOnly = true;
            // 
            // ItemAmountColumn
            // 
            this.ItemAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemAmountColumn.FillWeight = 26F;
            this.ItemAmountColumn.HeaderText = "Amount";
            this.ItemAmountColumn.Name = "ItemAmountColumn";
            // 
            // NahobinoTabPage
            // 
            this.NahobinoTabPage.Controls.Add(this.SetNahobinoToMaxButton);
            this.NahobinoTabPage.Controls.Add(this.LuckNumUpDown);
            this.NahobinoTabPage.Controls.Add(this.LuckLabel);
            this.NahobinoTabPage.Controls.Add(this.AgilityNumUpDown);
            this.NahobinoTabPage.Controls.Add(this.AgilityLabel);
            this.NahobinoTabPage.Controls.Add(this.MagicNumUpDown);
            this.NahobinoTabPage.Controls.Add(this.MagicLabel);
            this.NahobinoTabPage.Controls.Add(this.VitalityNumUpDown);
            this.NahobinoTabPage.Controls.Add(this.VitalityLabel);
            this.NahobinoTabPage.Controls.Add(this.StrengthNumUpDown);
            this.NahobinoTabPage.Controls.Add(this.StrengthLabel);
            this.NahobinoTabPage.Controls.Add(this.NahobinoMpNumericUpDown);
            this.NahobinoTabPage.Controls.Add(this.NahobinoMpLabel);
            this.NahobinoTabPage.Controls.Add(this.NahobinoHpNumericUpDown);
            this.NahobinoTabPage.Controls.Add(this.NahobinoHpLabel);
            this.NahobinoTabPage.Controls.Add(this.NahobinoExperienceNumUpDown);
            this.NahobinoTabPage.Controls.Add(this.NahobinoLevelNumUpDown);
            this.NahobinoTabPage.Controls.Add(this.NahobinoExperienceLabel);
            this.NahobinoTabPage.Controls.Add(this.NahobinoLevelLabel);
            this.NahobinoTabPage.Location = new System.Drawing.Point(4, 24);
            this.NahobinoTabPage.Name = "NahobinoTabPage";
            this.NahobinoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NahobinoTabPage.Size = new System.Drawing.Size(540, 231);
            this.NahobinoTabPage.TabIndex = 2;
            this.NahobinoTabPage.Text = "Nahobino Stats";
            this.NahobinoTabPage.UseVisualStyleBackColor = true;
            // 
            // SetNahobinoToMaxButton
            // 
            this.SetNahobinoToMaxButton.BackColor = System.Drawing.Color.Honeydew;
            this.SetNahobinoToMaxButton.Location = new System.Drawing.Point(384, 202);
            this.SetNahobinoToMaxButton.Name = "SetNahobinoToMaxButton";
            this.SetNahobinoToMaxButton.Size = new System.Drawing.Size(150, 23);
            this.SetNahobinoToMaxButton.TabIndex = 18;
            this.SetNahobinoToMaxButton.Text = "Set Everything to Max";
            this.SetNahobinoToMaxButton.UseVisualStyleBackColor = false;
            this.SetNahobinoToMaxButton.Click += new System.EventHandler(this.SetNahobinoToMaxButton_Click);
            // 
            // LuckNumUpDown
            // 
            this.LuckNumUpDown.Location = new System.Drawing.Point(291, 128);
            this.LuckNumUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.LuckNumUpDown.Name = "LuckNumUpDown";
            this.LuckNumUpDown.Size = new System.Drawing.Size(51, 23);
            this.LuckNumUpDown.TabIndex = 17;
            this.LuckNumUpDown.ValueChanged += new System.EventHandler(this.LuckNumUpDown_ValueChanged);
            // 
            // LuckLabel
            // 
            this.LuckLabel.AutoSize = true;
            this.LuckLabel.Location = new System.Drawing.Point(231, 130);
            this.LuckLabel.Name = "LuckLabel";
            this.LuckLabel.Size = new System.Drawing.Size(35, 15);
            this.LuckLabel.TabIndex = 16;
            this.LuckLabel.Text = "Luck:";
            // 
            // AgilityNumUpDown
            // 
            this.AgilityNumUpDown.Location = new System.Drawing.Point(291, 99);
            this.AgilityNumUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.AgilityNumUpDown.Name = "AgilityNumUpDown";
            this.AgilityNumUpDown.Size = new System.Drawing.Size(51, 23);
            this.AgilityNumUpDown.TabIndex = 15;
            this.AgilityNumUpDown.ValueChanged += new System.EventHandler(this.AgilityNumUpDown_ValueChanged);
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.AutoSize = true;
            this.AgilityLabel.Location = new System.Drawing.Point(231, 101);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(44, 15);
            this.AgilityLabel.TabIndex = 14;
            this.AgilityLabel.Text = "Agility:";
            // 
            // MagicNumUpDown
            // 
            this.MagicNumUpDown.Location = new System.Drawing.Point(291, 70);
            this.MagicNumUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.MagicNumUpDown.Name = "MagicNumUpDown";
            this.MagicNumUpDown.Size = new System.Drawing.Size(51, 23);
            this.MagicNumUpDown.TabIndex = 13;
            this.MagicNumUpDown.ValueChanged += new System.EventHandler(this.MagicNumUpDown_ValueChanged);
            // 
            // MagicLabel
            // 
            this.MagicLabel.AutoSize = true;
            this.MagicLabel.Location = new System.Drawing.Point(231, 72);
            this.MagicLabel.Name = "MagicLabel";
            this.MagicLabel.Size = new System.Drawing.Size(43, 15);
            this.MagicLabel.TabIndex = 12;
            this.MagicLabel.Text = "Magic:";
            // 
            // VitalityNumUpDown
            // 
            this.VitalityNumUpDown.Location = new System.Drawing.Point(291, 41);
            this.VitalityNumUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.VitalityNumUpDown.Name = "VitalityNumUpDown";
            this.VitalityNumUpDown.Size = new System.Drawing.Size(51, 23);
            this.VitalityNumUpDown.TabIndex = 11;
            this.VitalityNumUpDown.ValueChanged += new System.EventHandler(this.VitalityNumUpDown_ValueChanged);
            // 
            // VitalityLabel
            // 
            this.VitalityLabel.AutoSize = true;
            this.VitalityLabel.Location = new System.Drawing.Point(231, 43);
            this.VitalityLabel.Name = "VitalityLabel";
            this.VitalityLabel.Size = new System.Drawing.Size(46, 15);
            this.VitalityLabel.TabIndex = 10;
            this.VitalityLabel.Text = "Vitality:";
            // 
            // StrengthNumUpDown
            // 
            this.StrengthNumUpDown.Location = new System.Drawing.Point(291, 12);
            this.StrengthNumUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.StrengthNumUpDown.Name = "StrengthNumUpDown";
            this.StrengthNumUpDown.Size = new System.Drawing.Size(51, 23);
            this.StrengthNumUpDown.TabIndex = 9;
            this.StrengthNumUpDown.ValueChanged += new System.EventHandler(this.StrengthNumUpDown_ValueChanged);
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(230, 14);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(55, 15);
            this.StrengthLabel.TabIndex = 8;
            this.StrengthLabel.Text = "Strength:";
            // 
            // NahobinoMpNumericUpDown
            // 
            this.NahobinoMpNumericUpDown.Location = new System.Drawing.Point(106, 100);
            this.NahobinoMpNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NahobinoMpNumericUpDown.Name = "NahobinoMpNumericUpDown";
            this.NahobinoMpNumericUpDown.Size = new System.Drawing.Size(51, 23);
            this.NahobinoMpNumericUpDown.TabIndex = 7;
            this.NahobinoMpNumericUpDown.ValueChanged += new System.EventHandler(this.NahobinoMpNumericUpDown_ValueChanged);
            // 
            // NahobinoMpLabel
            // 
            this.NahobinoMpLabel.AutoSize = true;
            this.NahobinoMpLabel.Location = new System.Drawing.Point(7, 102);
            this.NahobinoMpLabel.Name = "NahobinoMpLabel";
            this.NahobinoMpLabel.Size = new System.Drawing.Size(84, 15);
            this.NahobinoMpLabel.TabIndex = 6;
            this.NahobinoMpLabel.Text = "Nahobino MP:";
            // 
            // NahobinoHpNumericUpDown
            // 
            this.NahobinoHpNumericUpDown.Location = new System.Drawing.Point(106, 71);
            this.NahobinoHpNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NahobinoHpNumericUpDown.Name = "NahobinoHpNumericUpDown";
            this.NahobinoHpNumericUpDown.Size = new System.Drawing.Size(51, 23);
            this.NahobinoHpNumericUpDown.TabIndex = 5;
            this.NahobinoHpNumericUpDown.ValueChanged += new System.EventHandler(this.NahobinoHpNumericUpDown_ValueChanged);
            // 
            // NahobinoHpLabel
            // 
            this.NahobinoHpLabel.AutoSize = true;
            this.NahobinoHpLabel.Location = new System.Drawing.Point(6, 72);
            this.NahobinoHpLabel.Name = "NahobinoHpLabel";
            this.NahobinoHpLabel.Size = new System.Drawing.Size(82, 15);
            this.NahobinoHpLabel.TabIndex = 4;
            this.NahobinoHpLabel.Text = "Nahobino HP:";
            // 
            // NahobinoExperienceNumUpDown
            // 
            this.NahobinoExperienceNumUpDown.Location = new System.Drawing.Point(106, 13);
            this.NahobinoExperienceNumUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NahobinoExperienceNumUpDown.Name = "NahobinoExperienceNumUpDown";
            this.NahobinoExperienceNumUpDown.Size = new System.Drawing.Size(94, 23);
            this.NahobinoExperienceNumUpDown.TabIndex = 2;
            this.NahobinoExperienceNumUpDown.ValueChanged += new System.EventHandler(this.NahobinoExperienceNumUpDown_ValueChanged);
            // 
            // NahobinoLevelNumUpDown
            // 
            this.NahobinoLevelNumUpDown.Location = new System.Drawing.Point(106, 42);
            this.NahobinoLevelNumUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NahobinoLevelNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NahobinoLevelNumUpDown.Name = "NahobinoLevelNumUpDown";
            this.NahobinoLevelNumUpDown.Size = new System.Drawing.Size(51, 23);
            this.NahobinoLevelNumUpDown.TabIndex = 3;
            this.NahobinoLevelNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NahobinoLevelNumUpDown.ValueChanged += new System.EventHandler(this.NahobinoLevelNumUpDown_ValueChanged);
            // 
            // NahobinoExperienceLabel
            // 
            this.NahobinoExperienceLabel.AutoSize = true;
            this.NahobinoExperienceLabel.Location = new System.Drawing.Point(6, 15);
            this.NahobinoExperienceLabel.Name = "NahobinoExperienceLabel";
            this.NahobinoExperienceLabel.Size = new System.Drawing.Size(86, 15);
            this.NahobinoExperienceLabel.TabIndex = 0;
            this.NahobinoExperienceLabel.Text = "Nahobino EXP:";
            // 
            // NahobinoLevelLabel
            // 
            this.NahobinoLevelLabel.AutoSize = true;
            this.NahobinoLevelLabel.Location = new System.Drawing.Point(7, 43);
            this.NahobinoLevelLabel.Name = "NahobinoLevelLabel";
            this.NahobinoLevelLabel.Size = new System.Drawing.Size(93, 15);
            this.NahobinoLevelLabel.TabIndex = 1;
            this.NahobinoLevelLabel.Text = "Nahobino Level:";
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
            this.MakeBackUpCheckbox.Checked = true;
            this.MakeBackUpCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
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
            ((System.ComponentModel.ISupportInitialize)(this.PlayTimeMinutesNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayTimeHoursNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloryNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaccaNumUpDown)).EndInit();
            this.ItemsTabPage.ResumeLayout(false);
            this.ItemsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemListDataGridView)).EndInit();
            this.NahobinoTabPage.ResumeLayout(false);
            this.NahobinoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuckNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgilityNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagicNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VitalityNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NahobinoMpNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NahobinoHpNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NahobinoExperienceNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NahobinoLevelNumUpDown)).EndInit();
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
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private NumericUpDown MaccaNumUpDown;
        private Label MaccaLabel;
        private NumericUpDown GloryNumUpDown;
        private Label GloryLabel;
        private Label PlayTimeLabel;
        private Label MinutesLabel;
        private NumericUpDown PlayTimeMinutesNumUpDown;
        private Label HoursLabel;
        private NumericUpDown PlayTimeHoursNumUpDown;
        private Label DateSavedLabel;
        private DateTimePicker DateSavedDateTimePicker;
        private ComboBox DifficultyComboBox;
        private Label DifficultyLabel;
        private Button ItemsSetAllTo99Button;
        private Button ItemsSetAllTo255Button;
        private DataGridView ItemListDataGridView;
        private DataGridViewTextBoxColumn ItemIndexColumn;
        private DataGridViewTextBoxColumn ItemNameColumn;
        private DataGridViewTextBoxColumn ItemTypeColumn;
        private DataGridViewTextBoxColumn ItemAmountColumn;
        private CheckBox ItemsShowUnusedCheckBox;
        private TabPage NahobinoTabPage;
        private Label NahobinoExperienceLabel;
        private Label NahobinoLevelLabel;
        private NumericUpDown NahobinoLevelNumUpDown;
        private NumericUpDown VitalityNumUpDown;
        private Label VitalityLabel;
        private NumericUpDown StrengthNumUpDown;
        private Label StrengthLabel;
        private NumericUpDown NahobinoMpNumericUpDown;
        private Label NahobinoMpLabel;
        private NumericUpDown NahobinoHpNumericUpDown;
        private Label NahobinoHpLabel;
        private NumericUpDown NahobinoExperienceNumUpDown;
        private NumericUpDown LuckNumUpDown;
        private Label LuckLabel;
        private NumericUpDown AgilityNumUpDown;
        private Label AgilityLabel;
        private NumericUpDown MagicNumUpDown;
        private Label MagicLabel;
        private Button SetNahobinoToMaxButton;
    }
}