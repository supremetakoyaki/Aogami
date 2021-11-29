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
            SerializeDemonControls();
            readyForUserInput = false;
        }

        private void ChangeFormSize(int width, int height)
        {
            float ScaleFactor = DeviceDpi / 96f;
            width = (int)Math.Floor(width * ScaleFactor);
            height = (int)Math.Floor(height * ScaleFactor);
            Size = new(width, height);
        }

        private void SerializeDemonControls()
        {
            for (int i = 7; i < 398; i++)
            {
                string spriteKey = $"Devil{i}";
                if (SMTVSpriteUtil.GetSprite(spriteKey) is Bitmap demonSprite)
                {
                    DemonImageList.Images.Add(spriteKey, demonSprite);
                }
            }

            DemonStockListView.SmallImageList = DemonImageList;
            
            for (int i = 0; i < 245; i++)
            {
                DemonTypeComboBox.Items.Add(SMTVDemonCollection.DemonList[i].CharacterName);
            }
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

            DemonStockListView.Items.Clear();
            ListViewItem nahobinoItem = new(new string[] { "Nahobino", "0" });
            nahobinoItem.ImageKey = "Devil370";
            nahobinoItem.Tag = 0;
            DemonStockListView.Items.Add(nahobinoItem);

            for (int i = 0; i < 24; i++)
            {
                short demonId = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonId + (i * 392));
                string demonName = "(empty)";
                string demonSprite = string.Empty;

                if (demonId != -1)
                {
                    SMTVDemon? demonObject = SMTVDemonCollection.DemonList.Values.FirstOrDefault(d => d.DevilId == demonId);
                    if (demonObject != null)
                    {
                        demonSprite = $"Devil{demonObject.SpriteId}";
                        demonName = demonObject.CharacterName;
                    }
                    else
                    {
                        demonName = "(Unknown)";
                    }
                }

                ListViewItem demonItem = new(new string[] { demonName, (i + 1).ToString() });
                demonItem.Tag = i + 1;
                demonItem.ImageKey = demonSprite;
                DemonStockListView.Items.Add(demonItem);
            }
            DemonStockListView.Items[0].Selected = true;

            readyForUserInput = true;
        }

        private void SerializeNahobino()
        {
            if (openedGameSaveData == null) return;

            int NahobinoExp = openedGameSaveData.RetrieveInt32(SMTVGameSaveDataOffsets.NahobinoExp);
            short NahobinoLevel = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoLevel);
            short NahobinoHp = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoHp3);
            short NahobinoMp = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoMp3);
            short NahobinoStrength = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoStrength3);
            short NahobinoVitality = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoVitality3);
            short NahobinoMagic = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoMagic3);
            short NahobinoAgility = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoAgility3);
            short NahobinoLuck = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.NahobinoLuck3);
            if (NahobinoExp < 0) NahobinoExp = 0;
            if (NahobinoLevel < 1) NahobinoLevel = 1;
            else if (NahobinoLevel > 999) NahobinoLevel = 999;
            if (NahobinoHp < 0) NahobinoHp = 0;
            else if (NahobinoHp > 9999) NahobinoHp = 9999;
            if (NahobinoMp < 0) NahobinoMp = 0;
            else if (NahobinoMp > 9999) NahobinoMp = 9999;
            if (NahobinoStrength < 0) NahobinoStrength = 0;
            else if (NahobinoStrength > 999) NahobinoStrength = 999;
            if (NahobinoVitality < 0) NahobinoVitality = 0;
            else if (NahobinoVitality > 999) NahobinoVitality = 999;
            if (NahobinoMagic < 0) NahobinoMagic = 0;
            else if (NahobinoMagic > 999) NahobinoMagic = 999;
            if (NahobinoAgility < 0) NahobinoAgility = 0;
            else if (NahobinoAgility > 999) NahobinoAgility = 999;
            if (NahobinoLuck < 0) NahobinoLuck = 0;
            else if (NahobinoLuck > 999) NahobinoLuck = 999;

            DemonTypeComboBox.Visible = false;
            DemonClearButton.Visible = false;
            DemonExperienceNumUpDown.Value = NahobinoExp;
            DemonLevelNumUpDown.Value = NahobinoLevel;
            DemonHpNumericUpDown.Value = NahobinoHp;
            DemonMpNumericUpDown.Value = NahobinoMp;
            StrengthNumUpDown.Value = NahobinoStrength;
            VitalityNumUpDown.Value = NahobinoVitality;
            MagicNumUpDown.Value = NahobinoMagic;
            AgilityNumUpDown.Value = NahobinoAgility;
            LuckNumUpDown.Value = NahobinoLuck;
        }

        private void SerializeDemon(int demonIndex)
        {
            if (openedGameSaveData == null) return;

            int offsetSum = (demonIndex - 1) * 392;
            short DemonId = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonId + offsetSum);
            int DemonExp = openedGameSaveData.RetrieveInt32(SMTVGameSaveDataOffsets.DemonExp + offsetSum);
            short DemonLevel = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonLevel + offsetSum);
            short DemonHp = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonHp3 + offsetSum);
            short DemonMp = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonMp3 + offsetSum);
            short DemonStrength = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonStrength3 + offsetSum);
            short DemonVitality = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonVitality3 + offsetSum);
            short DemonMagic = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonMagic3 + offsetSum);
            short DemonAgility = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonAgility3 + offsetSum);
            short DemonLuck = openedGameSaveData.RetrieveInt16(SMTVGameSaveDataOffsets.DemonLuck3 + offsetSum);

            if (DemonExp < 0) DemonExp = 0;
            if (DemonLevel < 1) DemonLevel = 1;
            else if (DemonLevel > 99) DemonLevel = 99;
            if (DemonHp < 0) DemonHp = 0;
            else if (DemonHp > 9999) DemonHp = 9999;
            if (DemonMp < 0) DemonMp = 0;
            else if (DemonMp > 9999) DemonMp = 9999;
            if (DemonStrength < 0) DemonStrength = 0;
            else if (DemonStrength > 999) DemonStrength = 999;
            if (DemonVitality < 0) DemonVitality = 0;
            else if (DemonVitality > 999) DemonVitality = 999;
            if (DemonMagic < 0) DemonMagic = 0;
            else if (DemonMagic > 999) DemonMagic = 999;
            if (DemonAgility < 0) DemonAgility = 0;
            else if (DemonAgility > 999) DemonAgility = 999;
            if (DemonLuck < 0) DemonLuck = 0;
            else if (DemonLuck > 999) DemonLuck = 999;

            DemonTypeComboBox.Visible = true;
            DemonClearButton.Visible = true;
            if (DemonId == -1 || SMTVDemonCollection.DemonList.Values.FirstOrDefault(d => d.DevilId == DemonId) is not SMTVDemon demonObject)
            {
                DemonTypeComboBox.SelectedIndex = -1;
            }
            else
            {
                DemonTypeComboBox.SelectedIndex = demonObject.Index;
            }

            DemonExperienceNumUpDown.Value = DemonExp;
            DemonLevelNumUpDown.Value = DemonLevel;
            DemonHpNumericUpDown.Value = DemonHp;
            DemonMpNumericUpDown.Value = DemonMp;
            StrengthNumUpDown.Value = DemonStrength;
            VitalityNumUpDown.Value = DemonVitality;
            MagicNumUpDown.Value = DemonMagic;
            AgilityNumUpDown.Value = DemonAgility;
            LuckNumUpDown.Value = DemonLuck;
        }

        private async void OpenSaveFileButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Shin Megami Tensei V save file|GameSave00;GameSave01;GameSave02;GameSave03;GameSave04;GameSave05;GameSave06;GameSave07;GameSave08;GameSave09;GameSave10;GameSave11;GameSave12;GameSave13;GameSave14;GameSave15;GameSave16;GameSave17;GameSave18;GameSave19";
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
            byte[] data = File.ReadAllBytes("CharacterName.uexp");

            System.Text.StringBuilder sb = new();
            int i = 231;
            int index = 0;
            int id = 0;
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

                if (!str.StartsWith("NOT USED"))
                {
                    sb.AppendLine($"{{ {index}, new({index++}, \"{str}\", {id}, {id}, {id}) }},");
                }
                id += 1;
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

        private void SetDemonToMaxButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;

            DemonExperienceNumUpDown.Value = DemonExperienceNumUpDown.Maximum;
            DemonLevelNumUpDown.Value = DemonLevelNumUpDown.Maximum;
            DemonHpNumericUpDown.Value = DemonHpNumericUpDown.Maximum;
            DemonMpNumericUpDown.Value = DemonMpNumericUpDown.Maximum;
            StrengthNumUpDown.Value = StrengthNumUpDown.Maximum;
            VitalityNumUpDown.Value = VitalityNumUpDown.Maximum;
            MagicNumUpDown.Value = MagicNumUpDown.Maximum;
            AgilityNumUpDown.Value = AgilityNumUpDown.Maximum;
            LuckNumUpDown.Value = LuckNumUpDown.Maximum;

            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp, (int)DemonExperienceNumUpDown.Value);
                openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp2, (int)DemonExperienceNumUpDown.Value);
                openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp3, (int)DemonExperienceNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoTitleLevel, (short)DemonLevelNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel, (short)DemonLevelNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel2, (short)DemonLevelNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel3, (short)DemonLevelNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp2, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp3, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp, (short)DemonMpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp2, (short)DemonMpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp3, (short)DemonMpNumericUpDown.Value);
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
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.DemonExp + offsetSum, (int)DemonExperienceNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLevel + offsetSum, (short)DemonLevelNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonHp + offsetSum, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonHp2 + offsetSum, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonHp3 + offsetSum, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMp + offsetSum, (short)DemonMpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMp2 + offsetSum, (short)DemonMpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMp3 + offsetSum, (short)DemonMpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonStrength + offsetSum, (short)StrengthNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonStrength2 + offsetSum, (short)StrengthNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonStrength3 + offsetSum, (short)StrengthNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonVitality + offsetSum, (short)VitalityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonVitality2 + offsetSum, (short)VitalityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonVitality3 + offsetSum, (short)VitalityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMagic + offsetSum, (short)MagicNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMagic2 + offsetSum, (short)MagicNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMagic3 + offsetSum, (short)MagicNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonAgility + offsetSum, (short)AgilityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonAgility2 + offsetSum, (short)AgilityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonAgility3 + offsetSum, (short)AgilityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLuck + offsetSum, (short)LuckNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLuck2 + offsetSum, (short)LuckNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLuck3 + offsetSum, (short)LuckNumUpDown.Value);
            }

            readyForUserInput = true;
        }

        private void DemonExperienceNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp, (int)DemonExperienceNumUpDown.Value);
                openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp2, (int)DemonExperienceNumUpDown.Value);
                openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.NahobinoExp3, (int)DemonExperienceNumUpDown.Value);
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.DemonExp + offsetSum, (int)DemonExperienceNumUpDown.Value);
            }
            readyForUserInput = true;
        }

        private void DemonLevelNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoTitleLevel, (short)DemonLevelNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel, (short)DemonLevelNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel2, (short)DemonLevelNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLevel3, (short)DemonLevelNumUpDown.Value);
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLevel + offsetSum, (short)DemonLevelNumUpDown.Value);;
            }
            readyForUserInput = true;
        }

        private void DemonHpNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp2, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoHp3, (short)DemonHpNumericUpDown.Value);
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonHp + offsetSum, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonHp2 + offsetSum, (short)DemonHpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonHp3 + offsetSum, (short)DemonHpNumericUpDown.Value);
            }
            readyForUserInput = true;
        }

        private void DemonMpNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp, (short)DemonMpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp2, (short)DemonMpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMp3, (short)DemonMpNumericUpDown.Value);
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMp + offsetSum, (short)DemonMpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMp2 + offsetSum, (short)DemonMpNumericUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMp3 + offsetSum, (short)DemonMpNumericUpDown.Value);
            }
            readyForUserInput = true;
        }

        private void StrengthNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoStrength, (short)StrengthNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoStrength2, (short)StrengthNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoStrength3, (short)StrengthNumUpDown.Value);
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonStrength + offsetSum, (short)StrengthNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonStrength2 + offsetSum, (short)StrengthNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonStrength3 + offsetSum, (short)StrengthNumUpDown.Value);
            }
            readyForUserInput = true;
        }

        private void VitalityNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoVitality, (short)VitalityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoVitality2, (short)VitalityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoVitality3, (short)VitalityNumUpDown.Value);
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonVitality + offsetSum, (short)VitalityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonVitality2 + offsetSum, (short)VitalityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonVitality3 + offsetSum, (short)VitalityNumUpDown.Value);
            }
            readyForUserInput = true;
        }

        private void MagicNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMagic, (short)MagicNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMagic2, (short)MagicNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoMagic3, (short)MagicNumUpDown.Value);
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMagic + offsetSum, (short)MagicNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMagic2 + offsetSum, (short)MagicNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMagic3 + offsetSum, (short)MagicNumUpDown.Value);
            }
            readyForUserInput = true;
        }

        private void AgilityNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoAgility, (short)AgilityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoAgility2, (short)AgilityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoAgility3, (short)AgilityNumUpDown.Value);
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonAgility + offsetSum, (short)AgilityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonAgility2 + offsetSum, (short)AgilityNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonAgility3 + offsetSum, (short)AgilityNumUpDown.Value);
            }
            readyForUserInput = true;
        }

        private void LuckNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0)
            {
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLuck, (short)LuckNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLuck2, (short)LuckNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.NahobinoLuck3, (short)LuckNumUpDown.Value);
            }
            else
            {
                int offsetSum = (DemonStockListView.SelectedIndices[0] - 1) * 392;
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLuck + offsetSum, (short)LuckNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLuck2 + offsetSum, (short)LuckNumUpDown.Value);
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLuck3 + offsetSum, (short)LuckNumUpDown.Value);
            }
            readyForUserInput = true;
        }

        private void DemonStockListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            readyForUserInput = false;
            if (DemonStockListView.SelectedIndices[0] == 0) SerializeNahobino();
            else SerializeDemon(DemonStockListView.SelectedIndices[0]);
            readyForUserInput = true;
        }

        private void DemonTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedItems.Count != 1) return;
            readyForUserInput = false;
            int demonIndex = (int)DemonStockListView.SelectedItems[0].Tag;
            int offsetSum = (demonIndex - 1) * 392;
            SMTVDemon? newDemon = SMTVDemonCollection.DemonList.Values.FirstOrDefault(x => x.Index == DemonTypeComboBox.SelectedIndex);
            if (newDemon != null)
            {
                openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonId + offsetSum, newDemon.DevilId);
                DemonStockListView.SelectedItems[0].ImageKey = $"Devil{newDemon.SpriteId}";
                DemonStockListView.SelectedItems[0].SubItems[0].Text = newDemon.CharacterName;
            }
            readyForUserInput = true;
        }

        private void DemonClearButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedItems.Count != 1) return;
            else if (MessageBox.Show("Are you sure you want to wipe out this demon?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            int demonIndex = (int)DemonStockListView.SelectedItems[0].Tag;
            if (demonIndex == 0)
            {
                MessageBox.Show("You can't remove Nahobino!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            readyForUserInput = false;
            int offsetSum = (demonIndex - 1) * 392;
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonId + offsetSum, -1);
            openedGameSaveData.UpdateInt32(SMTVGameSaveDataOffsets.DemonExp + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLevel + offsetSum, 1);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonHp + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonHp2 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonHp3 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMp + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMp2 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMp3 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonStrength + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonStrength2 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonStrength3 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonVitality + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonVitality2 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonVitality3 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMagic + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMagic2 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonMagic3 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonAgility + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonAgility2 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonAgility3 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLuck + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLuck2 + offsetSum, 0);
            openedGameSaveData.UpdateInt16(SMTVGameSaveDataOffsets.DemonLuck3 + offsetSum, 0);
            DemonStockListView.SelectedItems[0].ImageKey = null;
            DemonStockListView.SelectedItems[0].SubItems[0].Text = "(empty)";

            DemonTypeComboBox.SelectedIndex = -1;
            DemonExperienceNumUpDown.Value = 0;
            DemonLevelNumUpDown.Value = 1;
            DemonHpNumericUpDown.Value = 0;
            DemonMpNumericUpDown.Value = 0;
            StrengthNumUpDown.Value = 0;
            VitalityNumUpDown.Value = 0;
            MagicNumUpDown.Value = 0;
            AgilityNumUpDown.Value = 0;
            LuckNumUpDown.Value = 0;

            readyForUserInput = true;
        }

        private void EditSkillsButton_Click(object sender, EventArgs e)
        {
            if (openedGameSaveData == null || !readyForUserInput || DemonStockListView.SelectedIndices.Count != 1) return;
            DemonSkillEditorForm skillEditor = new(DemonStockListView.SelectedIndices[0], DemonStockListView.SelectedItems[0].SubItems[0].Text, openedGameSaveData);
            skillEditor.ShowDialog();
        }
    }
}