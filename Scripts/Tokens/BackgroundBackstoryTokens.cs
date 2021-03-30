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
            registry.Add(4121,
                BackgroundTextProvider.CreateFormattedTokens(TextFile.Formatting.JustifyLeft, NightbladeBackstory)
                );
            registry.Add(10000,
                BackgroundTextProvider.CreateFormattedTokens(TextFile.Formatting.JustifyLeft, MageBackstory2)
            );
        }

        static readonly string[] MageBackstory2 = new string[]
        {
            "For you, thinking of home rings memories of strict rules and methodical studies."
            , "Your mother was a famous mage of %q1, and your father was gone before you knew him"
            , "As far as you can remember, she has always ensured that all your time at home"
            , "was spent studying both her specialty and the other forms of magic. By the time you"
            , "entered formal studies, you were able to %q1a better than all the other students,"
            , "but that didn't help you make friends. Still, you persevered through your studies,"
            , "ultimately achieving only decent grades. During those years, you met quite the"
            , "funny %q10, named %b1n. %b1g3 dry humor carried you through hard times, and"
            , "you could hardly imagine times without %b1g2"
            , ""
            , "Test next paragraph."
        };

        static readonly string[] NightbladeBackstory = new string[]
        {
            "Though your childhood was similar to that of other"
            , "%ra children you knew, at age 10, your"
            , "father thought you ready to begin learning thieving"
            , "skills. You spent many happy hours in his work shop,"
            , "practicing initially %q1."
            , "Your skills developed slowly at first, and your father"
            , "seemed to have to suppress his impatience at times."
            , ""
            , "You applied yourself to your training more diligently"
            , "than ever. It gradually became apparent to both you"
            , "and your father that while you certainly would"
            , "become a competent thief given time, you would never"
            , "achieve his level of mastery."
            , ""
            , "While you were studying %q3 techniques"
            , "with your father, your mother began to teach you, in"
            , "her quiet way, the use of magicka. It did not"
            , "take long to determine that you had some definite"
            , "potential. You discovered that you could use both"
            , "sciences together, using the discipline from"
            , "your %q3 and %q4"
            , "training to accelerate your development of"
            , "%q2 spells."
            , ""
            , "Your mother introduced you to some unusual, non-human"
            , "creatures, mostly %q5."
            , "You learned not only not to fear them, but also some of"
            , "their language. One in particular, a female named %fn"
            , "took a liking to you and trained you further in spells"
            , "of %q6 than your mother ever could."
            , ""
            , "One night, your father brought you into his shop, a"
            , "serious expression on his face. He explained that an"
            , "agent of the Emperor himself had approached the"
            , "heads of the local Thieves and Mages Guild. He had told"
            , "them that the Emperor had heard rumors of a"
            , "%q8 named %b1n who was supposed to"
            , "have been allied with the imperial traitor Jagar Tharn."
            , "The Emperor dared not act against %b1n"
            , "without proper evidence to verify %b1g3 illegal actions."
            , "Your father suggested that, as a pair, you two were just"
            , "right for the assignment. Excited about the chance"
            , "to impress your father as much as the Emperor's reward,"
            , "you agreed at once."
            , ""
            , "Some nights later, you and your father broke into"
            , "%b1n's study and began searching for"
            , "evidence of conspiracy. A noise out in the hall"
            , "nearly caused you to drop the stack of papers you were"
            , "carrying. Quickly, as agreed before, you moved off to the"
            , "exit route carrying %b1n's materials"
            , "while your father headed off to provide a distraction. He"
            , "gave you a wink and disappeared. You left the castle, and"
            , "followed the escape route to your home."
            , ""
            , "There, a portly mage and an Imperial courier examined the"
            , "materials, and from their reactions, the evidence damned"
            , "%b1n. You sat with your mother and"
            , "fretfully awaited your father's return. The hours turned"
            , "to days, and you numbly realized that you would never see"
            , "your father again. The receipt of the Emperor's reward"
            , "seemed small consolation for your loss."
            , ""
            , "Some weeks later, a letter bearing the Imperial seal"
            , "arrived at your house. You were requested in the Imperial"
            , "City at once."
        };
    }
}
