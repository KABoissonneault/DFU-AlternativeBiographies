using System.Text.RegularExpressions;

using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Entity;
using DaggerfallWorkshop.Game.Utility;
using DaggerfallWorkshop.Utility;

namespace CustomBackgrounds
{
    class BackgroundBiogFileMacroDataSource : BiogFile.BiogFileMacroDataSource
    {
        public BackgroundBiogFileMacroDataSource(BiogFile biogFile)
            : base(biogFile)
        {

        }

        public override bool ExpandMacro(string macroType, out string textOut)
        {
            Regex nameRegex = new Regex("%b([0-9]+)n");
            Match nameMatch = nameRegex.Match(macroType);
            if (nameMatch.Success)
            {
                textOut = GetBackgroundCharacterName(int.Parse(nameMatch.Groups[1].Value));
                return true;
            }

            Regex pronounRegex = new Regex("%b([0-9]+)g([0-9a-z]+)");
            Match pronounMatch = pronounRegex.Match(macroType);
            if (pronounMatch.Success)
            {
                int characterIndex = int.Parse(pronounMatch.Groups[1].Value);
                string pronounType = pronounMatch.Groups[2].Value;
                switch (pronounType)
                {
                    case "1":
                        textOut = GetBackgroundCharacterPronoun1(characterIndex);
                        return true;
                    case "2":
                        textOut = GetBackgroundCharacterPronoun2(characterIndex);
                        return true;
                    case "2self":
                        textOut = GetBackgroundCharacterPronoun2self(characterIndex);
                        return true;
                    case "3":
                        textOut = GetBackgroundCharacterPronoun3(characterIndex);
                        return true;
                }
            }

            return base.ExpandMacro(macroType, out textOut);
        }

        private uint GetBackgroundCharacterSeed(int index)
        {
            return (uint)(parent.GetHashCode() + index);
        }

        private string GetBackgroundCharacterName(int index)
        {
            DFRandom.Seed = GetBackgroundCharacterSeed(index);
            NameHelper.BankTypes nameBank = MacroHelper.GetNameBank((Races)CharacterDocument.raceTemplate.ID);
            if (DFRandom.rand() % 2 == 0)
            {
                return DaggerfallUnity.Instance.NameHelper.FullName(nameBank, Genders.Male);
            }
            else
            {
                return DaggerfallUnity.Instance.NameHelper.FullName(nameBank, Genders.Female);
            }
        }

        private string GetBackgroundCharacterPronoun1(int index)
        {
            DFRandom.Seed = GetBackgroundCharacterSeed(index);
            if (DFRandom.rand() % 2 == 0)
            {
                return TextManager.Instance.GetLocalizedText("pronounHe");
            }
            else
            {
                return TextManager.Instance.GetLocalizedText("pronounShe");
            }
        }

        private string GetBackgroundCharacterPronoun2(int index)
        {
            DFRandom.Seed = GetBackgroundCharacterSeed(index);
            if (DFRandom.rand() % 2 == 0)
            {
                return TextManager.Instance.GetLocalizedText("pronounHim");
            }
            else
            {
                return TextManager.Instance.GetLocalizedText("pronounHer");
            }
        }

        private string GetBackgroundCharacterPronoun2self(int index)
        {
            DFRandom.Seed = GetBackgroundCharacterSeed(index);
            if (DFRandom.rand() % 2 == 0)
            {
                return TextManager.Instance.GetLocalizedText("pronounHimself");
            }
            else
            {
                return TextManager.Instance.GetLocalizedText("pronounHerself");
            }
        }

        private string GetBackgroundCharacterPronoun3(int index)
        {
            DFRandom.Seed = GetBackgroundCharacterSeed(index);
            if (DFRandom.rand() % 2 == 0)
            {
                return TextManager.Instance.GetLocalizedText("pronounHis");
            }
            else
            {
                return TextManager.Instance.GetLocalizedText("pronounHer");
            }
        }
    }
}
