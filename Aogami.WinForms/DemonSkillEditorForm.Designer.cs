namespace Aogami.WinForms
{
    partial class DemonSkillEditorForm
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
            this.SkillEditingGroupBox = new System.Windows.Forms.GroupBox();
            this.AddSkillToDemonButton = new System.Windows.Forms.Button();
            this.RemoveSkillFromDemonButton = new System.Windows.Forms.Button();
            this.SpecificDemonSkillsListView = new System.Windows.Forms.ListView();
            this.SpecificSkillNameColumn = new System.Windows.Forms.ColumnHeader();
            this.DemonNameSkillsLabel = new System.Windows.Forms.Label();
            this.AllSkillsLabel = new System.Windows.Forms.Label();
            this.AllSkillsListView = new System.Windows.Forms.ListView();
            this.SkillNameColumn = new System.Windows.Forms.ColumnHeader();
            this.SkillEditingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SkillEditingGroupBox
            // 
            this.SkillEditingGroupBox.Controls.Add(this.AddSkillToDemonButton);
            this.SkillEditingGroupBox.Controls.Add(this.RemoveSkillFromDemonButton);
            this.SkillEditingGroupBox.Controls.Add(this.SpecificDemonSkillsListView);
            this.SkillEditingGroupBox.Controls.Add(this.DemonNameSkillsLabel);
            this.SkillEditingGroupBox.Controls.Add(this.AllSkillsLabel);
            this.SkillEditingGroupBox.Controls.Add(this.AllSkillsListView);
            this.SkillEditingGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SkillEditingGroupBox.Name = "SkillEditingGroupBox";
            this.SkillEditingGroupBox.Size = new System.Drawing.Size(560, 337);
            this.SkillEditingGroupBox.TabIndex = 0;
            this.SkillEditingGroupBox.TabStop = false;
            this.SkillEditingGroupBox.Text = "Demon Skills";
            // 
            // AddSkillToDemonButton
            // 
            this.AddSkillToDemonButton.Location = new System.Drawing.Point(262, 203);
            this.AddSkillToDemonButton.Name = "AddSkillToDemonButton";
            this.AddSkillToDemonButton.Size = new System.Drawing.Size(36, 23);
            this.AddSkillToDemonButton.TabIndex = 6;
            this.AddSkillToDemonButton.Text = ">>";
            this.AddSkillToDemonButton.UseVisualStyleBackColor = true;
            this.AddSkillToDemonButton.Click += new System.EventHandler(this.AddSkillToDemonButton_Click);
            // 
            // RemoveSkillFromDemonButton
            // 
            this.RemoveSkillFromDemonButton.Location = new System.Drawing.Point(262, 136);
            this.RemoveSkillFromDemonButton.Name = "RemoveSkillFromDemonButton";
            this.RemoveSkillFromDemonButton.Size = new System.Drawing.Size(36, 23);
            this.RemoveSkillFromDemonButton.TabIndex = 5;
            this.RemoveSkillFromDemonButton.Text = "<<";
            this.RemoveSkillFromDemonButton.UseVisualStyleBackColor = true;
            this.RemoveSkillFromDemonButton.Click += new System.EventHandler(this.RemoveSkillFromDemonButton_Click);
            // 
            // SpecificDemonSkillsListView
            // 
            this.SpecificDemonSkillsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SpecificSkillNameColumn});
            this.SpecificDemonSkillsListView.FullRowSelect = true;
            this.SpecificDemonSkillsListView.Location = new System.Drawing.Point(304, 39);
            this.SpecificDemonSkillsListView.MultiSelect = false;
            this.SpecificDemonSkillsListView.Name = "SpecificDemonSkillsListView";
            this.SpecificDemonSkillsListView.Size = new System.Drawing.Size(250, 292);
            this.SpecificDemonSkillsListView.TabIndex = 4;
            this.SpecificDemonSkillsListView.UseCompatibleStateImageBehavior = false;
            this.SpecificDemonSkillsListView.View = System.Windows.Forms.View.Details;
            // 
            // SpecificSkillNameColumn
            // 
            this.SpecificSkillNameColumn.Text = "Name";
            this.SpecificSkillNameColumn.Width = 220;
            // 
            // DemonNameSkillsLabel
            // 
            this.DemonNameSkillsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DemonNameSkillsLabel.Location = new System.Drawing.Point(304, 19);
            this.DemonNameSkillsLabel.Name = "DemonNameSkillsLabel";
            this.DemonNameSkillsLabel.Size = new System.Drawing.Size(250, 17);
            this.DemonNameSkillsLabel.TabIndex = 3;
            this.DemonNameSkillsLabel.Text = "{DemonNameSkillsLabel}";
            this.DemonNameSkillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllSkillsLabel
            // 
            this.AllSkillsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllSkillsLabel.Location = new System.Drawing.Point(6, 19);
            this.AllSkillsLabel.Name = "AllSkillsLabel";
            this.AllSkillsLabel.Size = new System.Drawing.Size(250, 17);
            this.AllSkillsLabel.TabIndex = 2;
            this.AllSkillsLabel.Text = "All skills";
            this.AllSkillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllSkillsListView
            // 
            this.AllSkillsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SkillNameColumn});
            this.AllSkillsListView.FullRowSelect = true;
            this.AllSkillsListView.Location = new System.Drawing.Point(6, 39);
            this.AllSkillsListView.MultiSelect = false;
            this.AllSkillsListView.Name = "AllSkillsListView";
            this.AllSkillsListView.Size = new System.Drawing.Size(250, 292);
            this.AllSkillsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AllSkillsListView.TabIndex = 0;
            this.AllSkillsListView.UseCompatibleStateImageBehavior = false;
            this.AllSkillsListView.View = System.Windows.Forms.View.Details;
            // 
            // SkillNameColumn
            // 
            this.SkillNameColumn.Text = "Name";
            this.SkillNameColumn.Width = 220;
            // 
            // DemonSkillEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.SkillEditingGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DemonSkillEditorForm";
            this.Text = "Skill Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DemonSkillEditorForm_FormClosing);
            this.SkillEditingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox SkillEditingGroupBox;
        private ListView AllSkillsListView;
        private Button AddSkillToDemonButton;
        private Button RemoveSkillFromDemonButton;
        private ListView SpecificDemonSkillsListView;
        private Label DemonNameSkillsLabel;
        private Label AllSkillsLabel;
        private ColumnHeader SpecificSkillNameColumn;
        private ColumnHeader SkillNameColumn;
    }
}