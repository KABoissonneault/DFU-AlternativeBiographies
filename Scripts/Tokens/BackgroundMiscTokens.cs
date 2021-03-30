using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DaggerfallConnect.Arena2;

namespace CustomBackgrounds
{
    static class BackgroundMiscTokens
    {
        public static void RegisterTokens(Dictionary<int, TextFile.Token[]> registry)
        {
            registry.Add(10100,
                BackgroundTextProvider.CreateAlternativeTokens(MonkClasses)
            );
            registry.Add(10101,
                BackgroundTextProvider.CreateAlternativeTokens(MageClasses)
            );
            registry.Add(10102,
                BackgroundTextProvider.CreateAlternativeTokens(RogueClasses)
            );
            registry.Add(10103,
                BackgroundTextProvider.CreateAlternativeTokens(WarriorClasses)
            );
            registry.Add(10104,
                BackgroundTextProvider.CreateAlternativeTokens(AssassinClasses)
            );
        }

        static readonly string[] MonkClasses = new string[]
        {
            "monk"
            , "wrestler"
            , "martial artist"
            , "scholar"
        };

        static readonly string[] MageClasses = new string[]
        {
            "mage"
            , "spellsword"
            , "wizard"
            , "warlock"
        };

        static readonly string[] RogueClasses = new string[]
        {
            "rebel"
            , "rascal"
            , "scoundrel"
            , "rogue"
            , "villain"
        };

        static readonly string[] WarriorClasses = new string[]
        {
            "soldier"
            , "fighter"
            , "militant"
            , "warrior"
            , "gladiator"
        };

        static readonly string[] AssassinClasses = new string[]
        {
            "murder-for-hire"
            , "hitman"
            , "butcher"
            , "assassin"
            , "poisonmaker"
        };
    }
}
