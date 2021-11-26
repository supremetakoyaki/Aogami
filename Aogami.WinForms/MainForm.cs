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
            Size = new(333, 119);
            //DebugTestsButton.Visible = Debugger.IsAttached;
            readyForUserInput = false;
        }

        private void SerializeSaveFileData()
        {
            if (openedGameSaveData == null) return;
            readyForUserInput = false;
            FirstNameTextBox.Text = openedGameSaveData.RetrieveString(SMTVGameSaveDataOffsets.FirstName_a, 16, true);
            LastNameTextBox.Text = openedGameSaveData.RetrieveString(SMTVGameSaveDataOffsets.LastName, 16, true);

            int Macca = openedGameSaveData.RetrieveInt32(SMTVGameSaveDataOffsets.Macca);
            if (Macca < 0) Macca = 0;
            MaccaNumUpDown.Value = Macca;
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
                    Size = new(333, 119);
                    return;
                }

                Text = "Aogami — Shin Megami Tensei V Save Editor";
                SaveChangesButton.Enabled = true;
                Size = new(600, 420);
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
            openedGameSaveData.UpdateString(SMTVGameSaveDataOffsets.FirstName_a, FirstNameTextBox.Text, 8);
            openedGameSaveData.UpdateString(SMTVGameSaveDataOffsets.FirstName_b, FirstNameTextBox.Text, 8);
            openedGameSaveData.UpdateString(SMTVGameSaveDataOffsets.FirstName_c, FirstNameTextBox.Text, 8);
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
    }
}