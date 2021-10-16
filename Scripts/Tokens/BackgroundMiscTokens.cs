using System.Collections.Generic;

using DaggerfallConnect.Arena2;

namespace CustomBackgrounds
{
    static class BackgroundMiscTokens
    {
        public static void RegisterTokens(Dictionary<int, TextFile.Token[]> registry)
        {
            registry.Add(10100, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1a));
            registry.Add(10101, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1aa));
            registry.Add(10102, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1b));
            registry.Add(10103, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1ba));
            registry.Add(10104, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1c));
            registry.Add(10105, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1ca));
            registry.Add(10106, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1d));
            registry.Add(10107, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1da));
            registry.Add(10108, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1e));
            registry.Add(10109, BackgroundTextProvider.CreateSimpleTokens(Mage2Q1ea));

            registry.Add(10110, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12a));
            registry.Add(10111, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12aa));
            registry.Add(10112, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12ab));
            registry.Add(10113, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12b));
            registry.Add(10114, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12ba));
            registry.Add(10115, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12bb));
            registry.Add(10116, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12c));
            registry.Add(10117, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12ca));
            registry.Add(10118, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12cb));
            registry.Add(10119, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12d));
            registry.Add(10120, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12da));
            registry.Add(10121, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12db));
            registry.Add(10122, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12e));
            registry.Add(10123, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12ea));
            registry.Add(10124, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12eb));
            registry.Add(10125, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12f));
            registry.Add(10126, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12fa));
            registry.Add(10127, BackgroundTextProvider.CreateSimpleTokens(Mage2Q12fb));

            registry.Add(10128, BackgroundTextProvider.CreateSimpleTokens(Mage2Q10a));
            registry.Add(10129, BackgroundTextProvider.CreateSimpleTokens(Mage2Q10b));
            registry.Add(10130, BackgroundTextProvider.CreateSimpleTokens(Mage2Q10c));
            registry.Add(10131, BackgroundTextProvider.CreateSimpleTokens(Mage2Q10d));
            registry.Add(10132, BackgroundTextProvider.CreateSimpleTokens(Mage2Q10e));

            registry.Add(10133, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2a));
            registry.Add(10134, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2aa));
            registry.Add(10135, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2ab));
            registry.Add(10136, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2b));
            registry.Add(10137, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2ba));
            registry.Add(10138, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2bb));
            registry.Add(10139, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2c));
            registry.Add(10140, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2ca));
            registry.Add(10141, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2cb));
            registry.Add(10142, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2d));
            registry.Add(10143, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2da));
            registry.Add(10144, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2db));
            registry.Add(10145, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2e));
            registry.Add(10146, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2ea));
            registry.Add(10147, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2eb));
            registry.Add(10148, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2f));
            registry.Add(10149, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2fa));
            registry.Add(10150, BackgroundTextProvider.CreateSimpleTokens(Mage2Q2fb));
        }

        static readonly string Mage2Q1a = "a priestess who never seemed to extend the same kind of";
        static readonly string Mage2Q1aa = "doting care to you as to others.";
        static readonly string Mage2Q1b = "a woman who cared little for your safety in her often";
        static readonly string Mage2Q1ba = "dangerous laboratory home.";
        static readonly string Mage2Q1c = "a gentlewoman who was always scornful of those of";
        static readonly string Mage2Q1ca = "lesser breeding.";
        static readonly string Mage2Q1d = "the apathetic baroness that saw you more as a burden";
        static readonly string Mage2Q1da = "than close kin.";
        static readonly string Mage2Q1e = "an indifferent and mysterious woman who spent many";
        static readonly string Mage2Q1ea = "nights away from home and spoke very little of herself.";

        static readonly string Mage2Q12a = "Despite being supervised, you nevertheless got hold of";
        static readonly string Mage2Q12aa = "your tutor's often poisonous reagents, some of which might";
        static readonly string Mage2Q12ab = "have permanently affected you later in life.";
        static readonly string Mage2Q12b = "While you often had trouble staying focused during his\ndrawn-out lectures, nevertheless, you always impressed him with your progress.";
        static readonly string Mage2Q12ba = "drawn-out lectures, nevertheless, you always impressed him";
        static readonly string Mage2Q12bb = "with your progress.";
        static readonly string Mage2Q12c = "While you dutifully studied with him, he even became a pillar";
        static readonly string Mage2Q12ca = "in your life. Looking back, however, you only now realize just";
        static readonly string Mage2Q12cb = "how lonely you were.";
        static readonly string Mage2Q12d = "Even though you struggled due to your frail health, missing out";
        static readonly string Mage2Q12da = "on much valuable time studying, your dedication never faltered.";
        static readonly string Mage2Q12db = "";
        static readonly string Mage2Q12e = "Even though your body seemed weaker when in the presence";
        static readonly string Mage2Q12ea = "of magic, it would not stop you from becoming a brilliant and";
        static readonly string Mage2Q12eb = "talented student in years to come.";
        static readonly string Mage2Q12f = "You were his favourite, and the passion you showed for his";
        static readonly string Mage2Q12fa = "teaching overshadowed any other field of interest you might";
        static readonly string Mage2Q12fb = "have had.";

        static readonly string Mage2Q10a = "a quiet but devoted scholar";
        static readonly string Mage2Q10b = "from the same class as you";
        static readonly string Mage2Q10c = "a cunning and sharp-tongued youth";
        static readonly string Mage2Q10d = "who’s as large as a bear";
        static readonly string Mage2Q10e = "who was kinder than his facade could show";

        static readonly string Mage2Q2a = "Instinctively your fingertips released shocking sparks at the";
        static readonly string Mage2Q2aa = "two assailants as they were about to catch up, paralyzing";
        static readonly string Mage2Q2ab = "them thoroughly.";
        static readonly string Mage2Q2b = "You soon noticed that the stranger was bleeding. Hiding in a";
        static readonly string Mage2Q2ba = "dark alley, you cured his wound, a stab wound to his left arm,";
        static readonly string Mage2Q2bb = "with a simple healing touch.";
        static readonly string Mage2Q2c = "You wouldn't be able to outrun them, and as soon as you took a turn into the darkness, you cast Chameleon Form on";
        static readonly string Mage2Q2ca = "everyone. The two men ran by as if no soul was present.";
        static readonly string Mage2Q2cb = "";
        static readonly string Mage2Q2d = "You soon found yourself climbing buildings and using";
        static readonly string Mage2Q2da = "Slowfalling to leap to safety. Not long after, the agents could";
        static readonly string Mage2Q2db = "not keep up with your escape.";
        static readonly string Mage2Q2e = "With a simple detect spell, you navigated through the";
        static readonly string Mage2Q2ea = "labyrinthian alleys far away from them. In no time, there";
        static readonly string Mage2Q2eb = "would be no trace of the assailants.";
        static readonly string Mage2Q2f = "One of the agents was a nightblade as his hands began to";
        static readonly string Mage2Q2fa = "sparkle in familiar Force Bolts. With quick thinking, you Far";
        static readonly string Mage2Q2fb = "Silence him before any of you could be paralyzed.";
    }
}
