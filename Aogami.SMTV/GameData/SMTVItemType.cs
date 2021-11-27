namespace Aogami.SMTV.GameData
{
    public static class SMTVItemType
    {
        public enum ItemType
        {
            Unknown = -1,
            UsableItem,
            SkillGet,
            Essence, // utsusemi
            Relic,
            Important
        }

        public static ItemType GetItemType(int ItemIndex)
        {
            if (ItemIndex >= 0 && ItemIndex <= 220) return ItemType.UsableItem;
            else if (ItemIndex >= 221 && ItemIndex <= 310) return ItemType.SkillGet;
            else if (ItemIndex >= 311 && ItemIndex <= 615) return ItemType.Essence;
            else if (ItemIndex >= 616 && ItemIndex <= 655) return ItemType.Relic;
            else if (ItemIndex >= 656 && ItemIndex <= 855) return ItemType.Important;
            return ItemType.Unknown;
        }
    }
}
