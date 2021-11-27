using Aogami.SMTV.GameData;
using Aogami.SMTV.SaveData;
using Aogami.WinForms.Imaging;
using System.Diagnostics;

namespace Aogami.WinForms
{
    public partial class MainForm : Form
    {
        private SMTVGameSaveData? openedGameSaveData;
        private bool readyForUserInput;

        public MainForm()
        {
            InitializeComponent();
            BitmapDrawer.DrawResourceOnPictureBox("Logo", LogoPictureBox, true);
            ChangeFormSize(333, 119);
            DebugTestsButton.Visible = Debugger.IsAttached;
            readyForUserInput = false;
        }

        private void ChangeFormSize(int width, int height)
        {
            float ScaleFactor = DeviceDpi / 96f;
            width = (int)Math.Floor(width * ScaleFactor);
            height = (int)Math.Floor(height * ScaleFactor);
            Size = new(width, height);
        }

        private void SerializeSaveFileData()
        {
            if (openedGameSaveData == null) return;
            readyForUserInput = false;

            FirstNameTextBox.Text = openedGameSaveData.RetrieveString(SMTVGameSaveDataOffsets.FirstName, 16, true);
            LastNameTextBox.Text = openedGameSaveData.RetrieveString(SMTVGameSaveDataOffsets.LastName, 16, true);

            int PlayTime = openedGameSaveData.RetrieveInt32(SMTVGameSaveDataOffsets.PlayTime);
            if (PlayTime < 0) PlayTime = 0;
            else if (PlayTime > 35999940) PlayTime = 35999940;
            PlayTimeHoursNumUpDown.Value = PlayTime / 3600;
            PlayTimeMinutesNumUpDown.Value = PlayTime / 60 % 60;

            long DateSaved = openedGameSaveData.RetrieveInt64(SMTVGameSaveDataOffsets.DateSaved);
            if (DateSaved < 630823248000000000) DateSaved = 630823248000000000;
            else if (DateSaved > 662379552000000000) DateSaved = 662379552000000000;
            DateSavedDateTimePicker.Value = new(DateSaved, DateTimeKind.Local);

            int Difficulty = openedGameSaveData.RetrieveByte(SMTVGameSaveDataOffsets.GameDifficulty);
            if (Difficulty < 0 || Difficulty > 3) Difficulty = 2;
            DifficultyComboBox.SelectedIndex = Difficulty;

            int Macca = openedGameSaveData.RetrieveInt32(SMTVGameSaveDataOffsets.Macca);
            if (Macca < 0) Macca = 0;
            MaccaNumUpDown.Value = Macca;

            int Glory = openedGameSaveData.RetrieveInt32(SMTVGameSaveDataOffsets.Glory);
            if (Glory < 0) Glory = 0;
            GloryNumUpDown.Value = Glory;

            ItemListDataGridView.Rows.Clear();
            foreach (var kvp in SMTVItemCollection.ItemNames)
            {
                int itemIndex = kvp.Key;
                string itemName = kvp.Value;
                string itemType = SMTVItemType.GetItemType(itemIndex).ToString();
                int itemAmount = openedGameSaveData.RetrieveByte(SMTVGameSaveDataOffsets.ItemOffset + itemIndex);
                int itemRowIndex = ItemListDataGridView.Rows.Add();
                ItemListDataGridView.Rows[itemRowIndex].Cells[0].Value = itemIndex;
                ItemListDataGridView.Rows[itemRowIndex].Cells[1].Value = itemName;
                ItemListDataGridView.Rows[itemRowIndex].Cells[2].Value = itemType;
                ItemListDataGridView.Rows[itemRowIndex].Cells[3].Value = itemAmount;
                ItemListDataGridView.Rows[itemRowIndex].Tag = itemIndex;
                if (!ItemsShowUnusedCheckBox.Checked && itemName.StartsWith("NOT USED")) ItemListDataGridView.Rows[itemRowIndex].Visible = false;
            }

            int NahobinoExp = openedGameSaveData.RetrieveInt32(SMTVGameSaveDataOffsets.NahobinoExp);
            short NahobinoLevel = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoLevel);
            short NahobinoHp = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoHp);
            short NahobinoMp = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoMp);
            short NahobinoStrength = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoStrength);
            short NahobinoVitality = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoVitality);
            short NahobinoMagic = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoMagic);
            short NahobinoAgility = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoAgility);
            short NahobinoLuck = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoLuck);
            if (NahobinoExp < 0) NahobinoExp = 0;
            if (NahobinoLevel < 1) NahobinoLevel = 1;
            else if (NahobinoLevel > 99) NahobinoLevel = 99;
            if (NahobinoHp < 0) NahobinoHp = 0;
            else if (NahobinoHp > 9999) NahobinoHp = 9999;
            if (NahobinoMp < 0) NahobinoMp = 0;
            else if (NahobinoMp > 9999) NahobinoMp = 9999;
            if (NahobinoStrength < 0) NahobinoStrength = 0;
            else if (NahobinoStrength > 99) NahobinoStrength = 99;
            if (NahobinoVitality < 0) NahobinoVitality = 0;
            else if (NahobinoVitality > 99) NahobinoVitality = 99;
            if (NahobinoMagic < 0) NahobinoMagic = 0;
            else if (NahobinoMagic > 99) NahobinoMagic = 99;
            if (NahobinoAgility < 0) NahobinoAgility = 0;
            else if (NahobinoAgility > 99) NahobinoAgility = 99;
            if (NahobinoLuck < 0) NahobinoLuck = 0;
            else if (NahobinoLuck > 99) NahobinoLuck = 99;

            NahobinoExperienceNumUpDown.Value = NahobinoExp;
            NahobinoLevelNumUpDown.Value = NahobinoLevel;
            NahobinoHpNumericUpDown.Value = NahobinoHp;
            NahobinoMpNumericUpDown.Value = NahobinoMp;
            StrengthNumUpDown.Value = NahobinoStrength;
            VitalityNumUpDown.Value = NahobinoVitality;
            MagicNumUpDown.Value = NahobinoMagic;
            AgilityNumUpDown.Value = NahobinoAgility;
            LuckNumUpDown.Value = NahobinoLuck;

            readyForUserInput = true;
        }

        private async void OpenSaveFileButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Shin Megami Tensei V save file|GameSave00;GameSave01;GameSave02";
            ofd.Title = "Choose your Shin Megami Tensei V save file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openedGameSaveData = await SMTVGameSaveData.Create(ofd.FileName);
                if (openedGameSaveData == null)
                {
                    MessageBox.Show("It looks like this is not a valid save file. Make sure you try to open an encrypted, 388KB Shin Megami Tensei V save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Text = "Aogami";
                    SaveChangesButton.Enabled = false;
                    ChangeFormSize(333, 119);
                    return;
                }

                Text = "Aogami — Shin Megami Tensei V Save Editor";
                SaveChangesButton.Enabled = true;
                ChangeFormSize(600, 420);
                SerializeSaveFileData();
            }
        }

        private async void ImportDecryptedDataButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null) return;

            using OpenFileDialog ofd = new();
            ofd.Filter = "Shin Megami Tensei V decrypted save file|*.*";
            ofd.Title = "Choose your decrypted Shin Megami Tensei V save file";
            ofd.FileName = $"{Path.GetFileName(openedGameSaveData.FileName)}_DECRYPTED";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("Please note that this will overwrite everything in your current save file. Are you sure?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
                bool success = await openedGameSaveData.ImportDecryptedData(ofd.FileName);
                if (!success) MessageBox.Show("Your data could not be imported. Please check it is a decrypted, 388KB Shin Megami Tensei V save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Your data has been imported successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SerializeSaveFileData();
            }
        }

        private async void ExportDecryptedDataButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null) return;

            using SaveFileDialog sfd = new();
            sfd.Filter = "Shin Megami Tensei V decrypted save file|*.*";
            sfd.Title = "Save your decrypted Shin Megami Tensei V save file";
            sfd.FileName = $"{Path.GetFileName(openedGameSaveData.FileName)}_DECRYPTED";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                await openedGameSaveData.ExportDecryptedData(sfd.FileName);
                MessageBox.Show("Your data has been exported successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SerializeSaveFileData();
            }
        }

        private async void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null) return;

            bool makeBackUp = MakeBackUpCheckbox.Checked;
            byte outCode = await openedGameSaveData.SaveDataAsync(makeBackUp);

            if (makeBackUp && outCode != 4) MessageBox.Show("Changes saved successfully. However, I could not make a back-up because the original file was deleted somehow.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("Changes saved successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DebugTestsButton_Click(object sender, EventArgs e)
        {
            // I'm trying to read the game's files.
            byte[] data = File.ReadAllBytes("SkillName.uexp");

            System.Text.StringBuilder sb = new();
            int i = 231;
            int index = 0;
            while (i < data.Length)
            {
                int strLen = BitConverter.ToInt32(data, i) - 1;
                string str;

                if (strLen < 0)
                {
                    strLen *= -1;
                    strLen -= 1;
                    str = System.Text.Encoding.ASCII.GetString(data, i + 4, strLen * 2).Replace("\0", "").Replace("\u0019", "");
                    i += 486 + strLen;
                }
                else
                {
                    str = System.Text.Encoding.ASCII.GetString(data, i + 4, strLen);
                    i += 470 + strLen;
                }

                sb.AppendLine($"{{ {index++}, \"{str}\" }},");
            }

            File.WriteAllText("output_test.out", sb.ToString());
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            if (FirstNameTextBox.Text.Length > 8) FirstNameTextBox.Text = FirstNameTextBox.Text[..8];
            if (LastNameTextBox.Text.Length > 8) LastNameTextBox.Text = LastNameTextBox.Text[..8];
            openedGameSaveData.UpdateString(SMTVGameSaveDataOffsets.FirstName, FirstNameTextBox.Text, 8);
            openedGameSaveData.UpdateString(SMTVGameSaveDataOffsets.FirstName2, FirstNameTextBox.Text, 8);
            openedGameSaveData.UpdateString(SMTVGameSaveDataOffsets.FirstName3, FirstNameTextBox.Text, 8);
            openedGameSaveData.UpdateString(SMTVGameSaveDataOffsets.FullName, $"{FirstNameTextBox.Text} {LastNameTextBox.Text}", 20);
            readyForUserInput = true;
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            if (FirstNameTextBox.Text.Length > 8) FirstNameTextBox.Text = FirstNameTextBox.Text[..8];
            if (LastNameTextBox.Text.Length > 8) LastNameTextBox.Text = LastNameTextBox.Text[..8];
            openedGameSaveData.UpdateString(SMTVGameSaveDataOffsets.LastName, LastNameTextBox.Text);
            openedGameSaveData.UpdateString(SMTVGameSaveDataOffsets.FullName, $"{FirstNameTextBox.Text} {LastNameTextBox.Text}");
            readyForUserInput = true;
        }

        private void MaccaNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.Macca, (int)MaccaNumUpDown.Value);
            readyForUserInput = true;
        }

        private void GloryNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.Glory, (int)GloryNumUpDown.Value);
            readyForUserInput = true;
        }

        private void PlayTimeHoursNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            PlayTimeMinutesNumUpDown_ValueChanged(sender, e);
        }

        private void PlayTimeMinutesNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.PlayTime, (int)(PlayTimeHoursNumUpDown.Value * 3600 + PlayTimeMinutesNumUpDown.Value * 60));
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.PlayTime2, (int)(PlayTimeHoursNumUpDown.Value * 3600 + PlayTimeMinutesNumUpDown.Value * 60));
            readyForUserInput = true;
        }

        private void DateSavedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt64(SMTVGameSaveDataOffsets.DateSaved, DateSavedDateTimePicker.Value.Ticks);
            readyForUserInput = true;
        }

        private void DifficultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateByte(SMTVGameSaveDataOffsets.GameDifficulty, (byte)DifficultyComboBox.SelectedIndex);
            readyForUserInput = true;
        }

        private void ItemsShowUnusedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;

            bool showUnused = ItemsShowUnusedCheckBox.Checked;

            foreach (DataGridViewRow itemRow in ItemListDataGridView.Rows)
            {
                string itemName = (string)itemRow.Cells[1].Value;
                if (itemName.StartsWith("NOT USED")) itemRow.Visible = showUnused;
            }

            ItemListDataGridView.Refresh();
            readyForUserInput = true;
        }

        private void ItemListDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new(ItemAmountColumn_KeyPress);
            if (ItemListDataGridView.CurrentCell.ColumnIndex == 3)
            {
                if (e.Control is TextBox textBox)
                {
                    textBox.KeyPress += new KeyPressEventHandler(ItemAmountColumn_KeyPress);
                }
            }
        }

        private void ItemAmountColumn_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ItemListDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || e.ColumnIndex != 3) return;
            readyForUserInput = false;

            DataGridViewRow itemRow = ItemListDataGridView.Rows[e.RowIndex];
            if (itemRow.Tag is int itemIndex)
            {
                if (int.TryParse(itemRow.Cells[3].Value.ToString(), out int itemAmount))
                {
                    if (itemAmount < 0) itemAmount = 0;
                    else if (itemAmount > 255) itemAmount = 255;
                }

                itemRow.Cells[3].Value = itemAmount;
                openedGameSaveData.UpdateByte(SMTVGameSaveDataOffsets.ItemOffset + itemIndex, (byte)itemAmount);
            }

            readyForUserInput = true;
        }

        private void ItemsSetAllTo99Button_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;

            foreach (DataGridViewRow itemRow in ItemListDataGridView.Rows)
            {
                if (itemRow.Tag is int itemIndex)
                {
                    if (itemRow.Cells[1].Value.ToString() is string itemName && !itemName.StartsWith("NOT USED"))
                    {
                        itemRow.Cells[3].Value = 99;
                        openedGameSaveData.UpdateByte(SMTVGameSaveDataOffsets.ItemOffset + itemIndex, 99);
                    }
                }
            }

            readyForUserInput = true;
        }

        private void ItemsSetAllTo255Button_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;

            foreach (DataGridViewRow itemRow in ItemListDataGridView.Rows)
            {
                if (itemRow.Tag is int itemIndex)
                {
                    if (itemRow.Cells[1].Value.ToString() is string itemName && !itemName.StartsWith("NOT USED"))
                    {
                        itemRow.Cells[3].Value = 255;
                        openedGameSaveData.UpdateByte(SMTVGameSaveDataOffsets.ItemOffset + itemIndex, 255);
                    }
                }
            }

            readyForUserInput = true;
        }

        private void SetNahobinoToMaxButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;

            NahobinoExperienceNumUpDown.Value = NahobinoExperienceNumUpDown.Maximum;
            NahobinoLevelNumUpDown.Value = NahobinoLevelNumUpDown.Maximum;
            NahobinoHpNumericUpDown.Value = NahobinoHpNumericUpDown.Maximum;
            NahobinoMpNumericUpDown.Value = NahobinoMpNumericUpDown.Maximum;
            StrengthNumUpDown.Value = StrengthNumUpDown.Maximum;
            VitalityNumUpDown.Value = VitalityNumUpDown.Maximum;
            MagicNumUpDown.Value = MagicNumUpDown.Maximum;
            AgilityNumUpDown.Value = AgilityNumUpDown.Maximum;
            LuckNumUpDown.Value = LuckNumUpDown.Maximum;

            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp, (int)NahobinoExperienceNumUpDown.Value);
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp2, (int)NahobinoExperienceNumUpDown.Value);
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp3, (int)NahobinoExperienceNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel, (short)NahobinoLevelNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel2, (short)NahobinoLevelNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel3, (short)NahobinoLevelNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp, (short)NahobinoHpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp2, (short)NahobinoHpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp3, (short)NahobinoHpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp, (short)NahobinoMpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp2, (short)NahobinoMpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp3, (short)NahobinoMpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoStrength, (short)StrengthNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoStrength2, (short)StrengthNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoStrength3, (short)StrengthNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoVitality, (short)VitalityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoVitality2, (short)VitalityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoVitality3, (short)VitalityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMagic, (short)MagicNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMagic2, (short)MagicNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMagic3, (short)MagicNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoAgility, (short)AgilityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoAgility2, (short)AgilityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoAgility3, (short)AgilityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLuck, (short)LuckNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLuck2, (short)LuckNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLuck3, (short)LuckNumUpDown.Value);

            readyForUserInput = true;
        }

        private void NahobinoExperienceNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp, (int)NahobinoExperienceNumUpDown.Value);
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp2, (int)NahobinoExperienceNumUpDown.Value);
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp3, (int)NahobinoExperienceNumUpDown.Value);
            readyForUserInput = true;
        }

        private void NahobinoLevelNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel, (short)NahobinoLevelNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel2, (short)NahobinoLevelNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel3, (short)NahobinoLevelNumUpDown.Value);
            readyForUserInput = true;
        }

        private void NahobinoHpNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp, (short)NahobinoHpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp2, (short)NahobinoHpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp3, (short)NahobinoHpNumericUpDown.Value);
            readyForUserInput = true;
        }

        private void NahobinoMpNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp, (short)NahobinoMpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp2, (short)NahobinoMpNumericUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp3, (short)NahobinoMpNumericUpDown.Value);
            readyForUserInput = true;
        }

        private void StrengthNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoStrength, (short)StrengthNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoStrength2, (short)StrengthNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoStrength3, (short)StrengthNumUpDown.Value);
            readyForUserInput = true;
        }

        private void VitalityNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoVitality, (short)VitalityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoVitality2, (short)VitalityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoVitality3, (short)VitalityNumUpDown.Value);
            readyForUserInput = true;
        }

        private void MagicNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMagic, (short)MagicNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMagic2, (short)MagicNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMagic3, (short)MagicNumUpDown.Value);
            readyForUserInput = true;
        }

        private void AgilityNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoAgility, (short)AgilityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoAgility2, (short)AgilityNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoAgility3, (short)AgilityNumUpDown.Value);
            readyForUserInput = true;
        }

        private void LuckNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput) return;
            readyForUserInput = false;
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLuck, (short)LuckNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLuck2, (short)LuckNumUpDown.Value);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLuck3, (short)LuckNumUpDown.Value);
            readyForUserInput = true;
        }
    }
}