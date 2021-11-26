﻿namespace Aogami.SMTV.SaveData
{
    public static class SMTVGameSaveDataOffsets
    {
        // Protagonist Name
        public const int FirstName_a = 1036;
        public const int FirstName_b = 2308;
        public const int FirstName_c = 2352;
        public const int LastName = 2332;
        public const int FullName = 2372;

        // General
        public const int DateSaved = 1064; // long
        public const int GameDifficulty = 1072;
        public const int PlayTime = 1073; // in seconds (integer)
        public const int PlayTime2 = 1284; // in seconds (integer)
        public const int Macca = 12144;
        public const int Glory = 12168;

        // Items
        public const int ItemOffset = 13216; // byte (0 to 255)
    }
}
