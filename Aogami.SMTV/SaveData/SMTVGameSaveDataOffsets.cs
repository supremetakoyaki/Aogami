namespace Aogami.SMTV.SaveData
{
    public static class SMTVGameSaveDataOffsets
    {
        // Protagonist Name
        public const int FirstName = 1036;
        public const int FirstName2 = 2308;
        public const int FirstName3 = 2352;
        public const int LastName = 2332;
        public const int FullName = 2372; // FirstName {space} LastName

        // Title
        public const int NahobinoTitleLevel = 1084; // int
        public const int DemonTitleId = 1088; //int. There are two more.
        public const int DemonTitleLevel = 1092; //int. There are two more.

        // General
        public const int DateSaved = 1064; // long
        public const int GameDifficulty = 1072;
        public const int PlayTime = 1073; // in seconds (int). It seems this is what's shown in the file select.
        public const int PlayTime2 = 1284; // in seconds (int). It seems this is where the game's stopwatch picks from
        public const int Macca = 12144;
        public const int Glory = 12168;

        // Miracles
        public const int MiracleOffset = 12172; // byte (0 to 255)

        // Items
        public const int ItemOffset = 13216; // byte (0 to 255)

        // Nahobino Stats
        // Some of these are what's shown in the file select screen, others may be "Current Stat/Max Stat" and be shared space with rest of demons. (Investigate) 
        public const int NahobinoExp = 1348; // int
        public const int NahobinoExp2 = 1820; // int
        public const int NahobinoExp3 = 2292; // int
        public const int NahobinoLevel = 1356; // short
        public const int NahobinoLevel2 = 1828; // short. It seems this is the level that's shown in file select?
        public const int NahobinoLevel3 = 2300; // short. It seems this is what's shown in party thumbnail.
        public const int NahobinoHp = 2236; // short
        public const int NahobinoHp2 = 2268; // short
        public const int NahobinoHp3 = 2288; // short
        public const int NahobinoMp = 2238; // short
        public const int NahobinoMp2 = 2270; // short
        public const int NahobinoMp3 = 2290; // short
        public const int NahobinoStrength = 2240; // short
        public const int NahobinoStrength2 = 2256; // short
        public const int NahobinoStrength3 = 2272; // short
        public const int NahobinoVitality = 2242; // short
        public const int NahobinoVitality2 = 2258; // short
        public const int NahobinoVitality3 = 2274; // short
        public const int NahobinoMagic = 2244; // short
        public const int NahobinoMagic2 = 2260; // short
        public const int NahobinoMagic3 = 2276; // short
        public const int NahobinoAgility = 2246; // short
        public const int NahobinoAgility2 = 2262; // short
        public const int NahobinoAgility3 = 2278; // short
        public const int NahobinoLuck = 2248; // short
        public const int NahobinoLuck2 = 2264; // short
        public const int NahobinoLuck3 = 2280; // short
        public const int NahobinoSkillId = 2416; // short? +8

        // Demon Stats. +392
        public const int DemonExp = 2780; // int
        public const int DemonLevel = 2788; // short
        public const int DemonId = 2790; // short
        public const int DemonHp = 2708; // short
        public const int DemonHp2 = 2740; // short
        public const int DemonHp3 = 2776; // short
        public const int DemonMp = 2710; // short
        public const int DemonMp2 = 2742; // short
        public const int DemonMp3 = 2778; // short
        public const int DemonStrength = 2712; // short
        public const int DemonStrength2 = 2744; // short
        public const int DemonStrength3 = 2760; // short
        public const int DemonVitality = 2714; // short
        public const int DemonVitality2 = 2746; // short
        public const int DemonVitality3 = 2762; // short
        public const int DemonMagic = 2716; // short
        public const int DemonMagic2 = 2748; // short
        public const int DemonMagic3 = 2764; // short
        public const int DemonAgility = 2718; // short
        public const int DemonAgility2 = 2750; // short
        public const int DemonAgility3 = 2766; // short
        public const int DemonLuck = 2720; // short
        public const int DemonLuck2 = 2752; // short
        public const int DemonLuck3 = 2768; // short
        public const int DemonSkillId = 2800; // short? +8
    }
}
