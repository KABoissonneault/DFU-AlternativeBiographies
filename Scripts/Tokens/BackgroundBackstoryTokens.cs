using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DaggerfallConnect.Arena2;

namespace CustomBackgrounds
{
    static class BackgroundBackstoryTokens
    {
        public static void RegisterTokens(Dictionary<int, TextFile.Token[]> registry)
        {
            registry.Add(10000,
                BackgroundTextProvider.CreateFormattedTokens(TextFile.Formatting.JustifyLeft, MageBackstory2)
            );
        }

        static readonly string[] MageBackstory2 = new string[]
        {
            "Never knowing your parents, you spent your youth in the"
            , "turbulent care of your mother's sister;"
            , "%q1"
            , "%q1a"
            , ""
            , "Even though her presence in your early years was minimal,"
            , "she left you to explore her endless library and"
            , "enchanting gardens to your heart's content and even"
            , "hired a tutor to introduce you to the arcane arts as"
            , "you grew older."
            , ""
            , "%q12"
            , "%q12a"
            , "%q12b"
            , "As you slowly matured, one day, your aunt called you into"
            , "her study. You were anxious about what she might have to"
            , "say to you, but your eyes glimmered as she proposed that"
            , "you move to the city. There you would continue expanding"
            , "your knowledge in a more professional setting, as you had"
            , "far outgrown your tutor's knowledge."
            , ""
            , "You quickly took on the opportunity to move far away from"
            , "her, but you could never quite shake the feeling of loss"
            , "as you would leave your home and everything you knew behind."
            , "The following day you began packing your few possessions,"
            , "and within the week, you set out to the city."
            , ""
            , "Your days as a student were filled to the brim with endless"
            , "piles of reading material and boring essays. While there"
            , "were few days of rest, nevertheless you would find ways to"
            , "entertain yourself. Especially when your newly acquired"
            , "friend, %mn, %q10,"
            , "would come knocking on your window at night."
            , ""
            , "On one such evening, you both snuck outside, hoping to"
            , "catch a performance in a nearby theatre."
            , "You never were concerned that the streets might have been"
            , "dangerous, but while making your way, you and your friend"
            , "heard a distressing shriek from one of the side alleys."
            , "From there, a young man of similar age to you came running"
            , "by, pleading for help. Behind him were two agents, neither"
            , "of which seemed like honest men."
            , "%mn grabbed the stranger's arm and ran off into the alleys"
            , "with you."
            , "%q2"
            , "%q2a"
            , "%q2b"
            , ""
            , "Your group spent the rest of the evening hiding in your"
            , "room, and you could never quite comprehend what had just"
            , "happened. The stranger, who thanked the two of you"
            , "profusely, introduced himself as %imp."
            , "The next night he left after promising to repay the"
            , "kindness that you two had shown him."
            , "You never made much of the event afterwards, and life"
            , "resumed as ever."
            , ""
            , "After the year had gone by, it was time to return home"
            , "to your aunt's estate for the time being. You were much"
            , "wiser and more mature than the last time you were here,"
            , "and the relationship between you two had warmed, if"
            , "only slightly."
            , ""
            , "One day as you were researching in your private study,"
            , "your aunt entered with a smile on her face that you"
            , "rarely ever saw directed at you. She announced that it"
            , "was a letter from the imperial city before placing it on"
            , "the desk and sliding it your way."
            , "You took it into your hand and inspected the waxy seal."
            , "It bore the emblem of the Emperor."
        };
    }
}
