﻿using System;
using System.Collections.Generic;

namespace CapitaineToinon.DarkSoulsMemory
{
    internal enum HookingStates
    {
        Unhooked,
        Hooked,
        CheckingProcess,
        Start,
    }

    internal enum GameVersion
    {
        Release,
        Debug,
        Unknown, // Who cares about beta
    }

    internal enum PointerType
    {
        updateFullyKindledBonfires,
        GetClearCount,
        IsPlayerLoaded,
        GetPlayerStartingClass,
        GetPlayerCharacterType,
        GetIngameTimeInMilliseconds
    }

    internal enum PlayerStartingClass
    {
        None = -1,
        Warrior = 0,
        Knight = 1,
        Wanderer = 2,
        Thief = 3,
        Bandit = 4,
        Hunter = 5,
        Sorcerer = 6,
        Pyromancer = 7,
        Cleric = 8,
        Deprived = 9
    }

    internal enum PlayerCharacterType
    {
        None = -1,
        Human = 0,
        Summon = 1,
        Invader = 2,
        Hollow = 8
    }

    internal enum NPC
    {
        // NPCs not tied to questlines
        Andre = 1322,
        GiantBlacksmith = 1362,
        Vamos = 1342,
        Eingyi = 1284,
        Gough = 1823,
        Chester = 1842,
        Oswald = 1702,
        Petrus = 1198,
        Quelana = 1295,
        ShivaBodyguard = 1764,
        UndeadMerchantMale = 1402,
        Domhnall = 1435,

        // And the rest
        Logan = 1097,
        Elizabeth = 1872,
        Griggs = 1115,
        DarklingLady = 1034,
        Patches = 1628,
        Rhea = 1177,
        Shiva = 1604,
        FairLady = 1272,
        Ciaran = 1864,
        Siegmeyer = 1513,
        Pharis = 11200818,
        SifRescuedInDLC = 11210021,
        CarvingMimicInDLC = 11210681,
        CrestKeyMimicInDLC = 11210680,
        SunlightMaggotChaosFirebug = 800,
        HollowedOscar = 1062,
    }

    internal static class Dictionaries
    {
        public static Dictionary<string, int> EventFlagGroups = new Dictionary<string, int>()
        {
            {"0", 0x00000},
            {"1", 0x00500},
            {"5", 0x05F00},
            {"6", 0x0B900},
            {"7", 0x11300},
        };

        public static Dictionary<string, int> EventFlagAreas = new Dictionary<string, int>()
        {
            {"000", 00},
            {"100", 01},
            {"101", 02},
            {"102", 03},
            {"110", 04},
            {"120", 05},
            {"121", 06},
            {"130", 07},
            {"131", 08},
            {"132", 09},
            {"140", 10},
            {"141", 11},
            {"150", 12},
            {"151", 13},
            {"160", 14},
            {"170", 15},
            {"180", 16},
            {"181", 17},
        };
        // Dictionary for the starting items in Asylum. Key is the starting class, values are the starting item flags
        public static Dictionary<PlayerStartingClass, int[]> StartingClassItems
        {
            get
            {
                return new Dictionary<PlayerStartingClass, int[]>
                {
                    { PlayerStartingClass.Warrior, new int[] { 51810110, 51810100 } },
                    { PlayerStartingClass.Knight, new int[] { 51810130, 51810120 } },
                    { PlayerStartingClass.Wanderer, new int[] { 51810150, 51810140 } },
                    { PlayerStartingClass.Thief, new int[] { 51810170, 51810160 } },
                    { PlayerStartingClass.Bandit, new int[] { 51810190, 51810180 } },
                    { PlayerStartingClass.Hunter, new int[] { 51810210, 51810200, 51810220 } },
                    { PlayerStartingClass.Sorcerer, new int[] { 51810240, 51810230, 51810250 } },
                    { PlayerStartingClass.Pyromancer, new int[] { 51810270, 51810260, 51810280 } },
                    { PlayerStartingClass.Cleric, new int[] { 51810300, 51810290, 51810310 } },
                    { PlayerStartingClass.Deprived, new int[] { 51810330, 51810320 } },
                    { PlayerStartingClass.None, new int[] { } }
                };
            }
        }



        // Dictionary for the dropped item flags of each NPC. Key is the dead flag for each NPC, values are the dropped item flags
        public static Dictionary<NPC, int[]> NpcDroppedItems
        {
            get
            {
                return new Dictionary<NPC, int[]>
                {
                    // Permanent dropped items from NPCs
                    { NPC.Andre, new int[] { 51010990 } },
                    { NPC.GiantBlacksmith, new int[] { 51510940 } },
                    { NPC.Vamos, new int[] { 51300990, 51300991 } },
                    { NPC.Logan, new int[] { 50007031, 50007030 } },
                    { NPC.Eingyi, new int[] { 51400980 } },
                    { NPC.Elizabeth, new int[] { 50000520 } },
                    { NPC.Griggs, new int[] { 50006041, 50006040 } },
                    { NPC.Gough, new int[] { 50000510, 50000511 } },
                    { NPC.DarklingLady, new int[] { 50006010 } },
                    { NPC.Chester, new int[] { 51210990 } },
                    { NPC.Oswald, new int[] { 11607020, 50006371 } },
                    { NPC.Patches, new int[] { 50006320, 50006321 } },
                    { NPC.Petrus, new int[] { 50006080, 50006081 } },
                    { NPC.Quelana, new int[] { 50000300 } },
                    { NPC.Rhea, new int[] { 50006070, 50006072 } },
                    { NPC.Shiva, new int[] { 50006310, 50006311 } },
                    { NPC.ShivaBodyguard, new int[] { 50006420, 50006421 } },
                    { NPC.UndeadMerchantMale, new int[] { 51010960 } },
                    { NPC.FairLady, new int[] { 51400990 } },
                    { NPC.Ciaran, new int[] { 50000501, 50000500 } },
                    { NPC.Siegmeyer, new int[] { 50006280, 50000070 } },
                    { NPC.Pharis, new int[] { 50008000, 50008001 } },
                    { NPC.SifRescuedInDLC, new int[] { 51210910 } },
                    { NPC.CarvingMimicInDLC, new int[] { 51210921 } },
                    { NPC.CrestKeyMimicInDLC, new int[] { 51210981 } },
                    { NPC.SunlightMaggotChaosFirebug, new int[] { 51410990 } },
                    { NPC.HollowedOscar, new int[] { 50007020 } }
                };
            }
        }



        // Dictionary for the hostile flags of each NPC that isn't tied to a questline. Key is just an index, values are the hostile and dead flags
        public static List<int[]> NpcHostileDeadFlags
        {
            get
            {
                return new List<int[]>
                {
                    // NPCs not tied to questlines
                    new int[] { 1321, 1322 }, // 'Andre
                    new int[] { 1361, 1362 }, // 'Giant Blacksmith
                    new int[] { 1341, 1342 }, // 'Vamos
                    new int[] { 1283, 1284 }, // 'Eingyi
                    new int[] { 1822, 1823 }, // 'Gough
                    new int[] { 1841, 1842 }, // 'Chester
                    new int[] { 1701, 1702 }, // 'Oswald
                    new int[] { 1197, 1198 }, // 'Petrus
                    new int[] { 1294, 1295 }, // 'Quelana
                    new int[] { 1763, 1764 }, // 'Shiva's Bodyguard
                    new int[] { 1401, 1402 }, // 'Undead Merchant (Male)
                    new int[] { 1434, 1435 } // 'Domhnall
                };
            }
        }


        // Dictionary for treasure locations that have multiple pickups/event flags associated with it. Key is the first flag, values are the remaining flags
        public static Dictionary<int, int[]> SharedTreasureLocationItems
        {
            get
            {
                return new Dictionary<int, int[]>
                {
                    { 50001030, new int[] { 50001031 } }, //  'Dingy Set + Black Eye Orb
                    { 51010380, new int[] { 51010381 } }, //  'Thief Set + Target Shield
                    { 51010510, new int[] { 51010511 } }, //  'Sorcerer Set + Sorcerer Catalyst
                    { 51200020, new int[] { 51200021 } }, //  'Hunter Set + Longbow
                    { 51200140, new int[] { 51200141, 51200142 } }, // 'Divine Ember + Watchtower Basement Key + Homeward Bone
                    { 51300190, new int[] { 51300191 } }, //  'Cleric Set + Mace
                    { 51400190, new int[] { 51400191 } }, //  'Crimson Set + Tin Banishment Catalyst
                    { 51400270, new int[] { 51000271 } }, //  'Poison Mist + Pyromancer Set
                    { 51400310, new int[] { 51400311 } }, //  'Wanderer Set + Falchion
                    { 51500060, new int[] { 51500061 } }, //  'Black Sorcerer Set + Hush
                    { 51510070, new int[] { 51510071 } }, //  'Black Iron Set + Greatsword/Black Iron Greatshield
                    { 51600220, new int[] { 51600221 } }, //  'Bandit Set + Spider Shield
                    { 51600360, new int[] { 51600361 } }, //  'Witch Set + Beatrice's Catalyst
                    { 51700070, new int[] { 51700071 } }, //  'Maiden Set + White Seance Ring
                    { 51700640, new int[] { 51700641 } } //  'Sage Set + Logan's Catalyst
                };
            }
        }

    }
}
