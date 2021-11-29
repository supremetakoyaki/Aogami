using Aogami.SMTV.GameData;
using Aogami.SMTV.SaveData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aogami.WinForms
{
    public partial class DemonSkillEditorForm : Form
    {
        private readonly int _demonIndex;
        private readonly SMTVGameSaveData _openedGameSaveData;
        private int baseOffset;

        public DemonSkillEditorForm(int demonIndex, string demonName, SMTVGameSaveData openedGameSaveData)
        {
            InitializeComponent();
            _demonIndex = demonIndex;
            _openedGameSaveData = openedGameSaveData;
            DemonNameSkillsLabel.Text = $"{demonName}'s skills";
            SerializeSkills();
        }

        private void SerializeSkills()
        {
            if (_demonIndex == 0) baseOffset = SMTVGameSaveDataOffsets.NahobinoSkillId;
            else baseOffset = SMTVGameSaveDataOffsets.DemonSkillId + ((_demonIndex - 1) * 392);

            for (int i = 0; i < 8; i++)
            {
                int offsetSum = baseOffset + (i * 8);
                short skillId = _openedGameSaveData.RetrieveInt16(offsetSum);
                if (SMTVSkillCollection.SkillNames.TryGetValue(skillId - 1, out string? skillName))
                {
                    ListViewItem skillItem = new(skillName);
                    skillItem.Name = skillName;
                    skillItem.Tag = skillId;
                    SpecificDemonSkillsListView.Items.Add(skillItem);
                }
            }

            if (SpecificDemonSkillsListView.Items.Count > 7) AddSkillToDemonButton.Enabled = false;

            foreach (var skillKvp in SMTVSkillCollection.SkillNames)
            {
                if (!skillKvp.Value.StartsWith("NOT USED") && !SpecificDemonSkillsListView.Items.ContainsKey(skillKvp.Value))
                {
                    ListViewItem skillItem = new(skillKvp.Value);
                    skillItem.Name = skillKvp.Value;
                    skillItem.Tag = (short)(skillKvp.Key + 1);
                    AllSkillsListView.Items.Add(skillItem);
                }
            }
        }

        private void SaveDemonSkills()
        {
            if (_demonIndex == 0) baseOffset = SMTVGameSaveDataOffsets.NahobinoSkillId;
            else baseOffset = SMTVGameSaveDataOffsets.DemonSkillId + ((_demonIndex - 1) * 392);

            for (int i = 0; i < 8; i++)
            {
                int offsetSum = baseOffset + (i * 8);
                short skillId = 0;

                if (SpecificDemonSkillsListView.Items.Count > i)
                {
                    skillId = (short)SpecificDemonSkillsListView.Items[i].Tag;
                }

                _openedGameSaveData.UpdateInt16(offsetSum, skillId);
            }
        }

        private void AddSkillToDemonButton_Click(object sender, EventArgs e)
        {
            if (AllSkillsListView.SelectedItems.Count != 1 || SpecificDemonSkillsListView.Items.Count > 7) return;

            ListViewItem skillItemToAdd = AllSkillsListView.SelectedItems[0];
            AllSkillsListView.Items.Remove(skillItemToAdd);
            SpecificDemonSkillsListView.Items.Add(skillItemToAdd);

            if (SpecificDemonSkillsListView.Items.Count > 7) AddSkillToDemonButton.Enabled = false;
        }

        private void RemoveSkillFromDemonButton_Click(object sender, EventArgs e)
        {
            if (SpecificDemonSkillsListView.SelectedItems.Count != 1) return;

            ListViewItem skillItemToRemove = SpecificDemonSkillsListView.SelectedItems[0];
            AllSkillsListView.Items.Add(skillItemToRemove);
            SpecificDemonSkillsListView.Items.Remove(skillItemToRemove);

            if (!AddSkillToDemonButton.Enabled) AddSkillToDemonButton.Enabled = true;
        }

        private void DemonSkillEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDemonSkills();
        }
    }
}
