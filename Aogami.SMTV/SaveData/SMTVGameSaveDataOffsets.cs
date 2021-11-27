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

        // General
        public const int DateSaved = 1064; // long
        public const int GameDifficulty = 1072;
        public const int PlayTime = 1073; // in seconds (int). It seems this is what's shown in the file select.
        public const int PlayTime2 = 1284; // in seconds (int). It seems this is where the game's stopwatch picks from
        public const int Macca = 12144;
        public const int Glory = 12168;

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
    }
}
