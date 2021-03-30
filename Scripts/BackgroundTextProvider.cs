using System.Collections.Generic;
using System.Linq;

using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Utility;
using DaggerfallWorkshop.Game.Items;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization.Settings;

namespace CustomBackgrounds
{
    public class BackgroundTextProvider : ITextProvider
    {
        public static TextFile.Token[] CreateFormattedTokens(TextFile.Formatting formatting, params string[] lines)
        {
            List<TextFile.Token> tokens = new List<TextFile.Token>();

            foreach (string line in lines)
            {
                tokens.Add(new TextFile.Token(TextFile.Formatting.Text, line));
                tokens.Add(new TextFile.Token(formatting));
            }

            tokens.Add(new TextFile.Token(TextFile.Formatting.EndOfRecord));

            return tokens.ToArray();
        }

        public static TextFile.Token[] CreateAlternativeTokens(params string[] lines)
        {
            if (lines.Count() == 0)
                return Enumerable.Empty<TextFile.Token>().ToArray();

            List<TextFile.Token> tokens = new List<TextFile.Token>();

            for(int i = 0; i < lines.Count() - 1; ++i)
            {
                tokens.Add(new TextFile.Token(TextFile.Formatting.Text, lines[i]));
                tokens.Add(new TextFile.Token(TextFile.Formatting.SubrecordSeparator));
            }

            tokens.Add(new TextFile.Token(TextFile.Formatting.Text, lines[lines.Count() - 1]));
            tokens.Add(new TextFile.Token(TextFile.Formatting.EndOfRecord));

            return tokens.ToArray();
        }

        ITextProvider fallback;
        Dictionary<int, TextFile.Token[]> customTokens = new Dictionary<int, TextFile.Token[]>();

        public BackgroundTextProvider(ITextProvider fallbackProvider)
        {
            fallback = fallbackProvider;

            BackgroundBackstoryTokens.RegisterTokens(customTokens);
            BackgroundMiscTokens.RegisterTokens(customTokens);
        }

        /// <summary>
        /// Gets tokens from a TEXT.RSC record.
        /// </summary>
        /// <param name="id">Text resource ID.</param>
        /// <returns>Text resource tokens.</returns>
        public TextFile.Token[] GetRSCTokens(int id)
        {
            TextFile.Token[] backgroundTokens;
            if (customTokens.TryGetValue(id, out backgroundTokens))
                return backgroundTokens;

            return fallback.GetRSCTokens(id);
        }

        /// <summary>
        /// Gets tokens from RSC localization table with custom string ID and conversion back to RSC tokens.
        /// Does not support fallback to classic TEXT.RSC. Record key must exist in RSC localization table.
        /// </summary>
        /// <param name="id">String table key.</param>
        /// <returns>Text resource tokens.</returns>
        public TextFile.Token[] GetRSCTokens(string id)
        {
            return fallback.GetRSCTokens(id);
        }

        /// <summary>
        /// Gets tokens from a randomly selected subrecord.
        /// </summary>
        /// <param name="id">Text resource ID.</param>
        /// <param name="dfRand">Use Daggerfall rand() for random selection.</param>
        /// <returns>Text resource tokens.</returns>
        public TextFile.Token[] GetRandomTokens(int id, bool dfRand = false)
        {
            return fallback.GetRandomTokens(id, dfRand);
        }

        /// <summary>
        /// Creates a custom token array.
        /// </summary>
        /// <param name="formatting">Formatting of each line.</param>
        /// <param name="lines">All text lines.</param>
        /// <returns>Token array.</returns>
        public TextFile.Token[] CreateTokens(TextFile.Formatting formatting, params string[] lines)
        {
            return fallback.CreateTokens(formatting, lines);
        }

        /// <summary>
        /// Gets string from token array.
        /// </summary>
        /// <param name="id">Text resource ID.</param>
        /// <returns>String from text resource.</returns>
        public string GetText(int id)
        {
            return fallback.GetText(id);
        }

        /// <summary>
        /// Gets random string from separated token array.
        /// Example would be flavour text variants when finding dungeon exterior.
        /// </summary>
        /// <param name="id">Text resource ID.</param>
        /// <returns>String randomly selected from variants.</returns>
        public string GetRandomText(int id)
        {
            return fallback.GetRandomText(id);
        }

        /// <summary>
        /// Gets name of weapon material type.
        /// </summary>
        /// <param name="material">Material type of weapon.</param>
        /// <returns>String for weapon material name.</returns>
        public string GetWeaponMaterialName(WeaponMaterialTypes material)
        {
            return fallback.GetWeaponMaterialName(material);
        }

        /// <summary>
        /// Gets name of armor material type.
        /// </summary>
        /// <param name="material">Material type of armor.</param>
        /// <returns>String for armor material name.</returns>
        public string GetArmorMaterialName(ArmorMaterialTypes material)
        {
            return fallback.GetArmorMaterialName(material);
        }

        /// <summary>
        /// Gets text for skill name.
        /// </summary>
        /// <param name="skill">Skill.</param>
        /// <returns>Text for this skill.</returns>
        public string GetSkillName(DFCareer.Skills skill)
        {
            return fallback.GetSkillName(skill);
        }

        /// <summary>
        /// Gets text for stat name.
        /// </summary>
        /// <param name="stat">Stat.</param>
        /// <returns>Text for this stat.</returns>
        public string GetStatName(DFCareer.Stats stat)
        {
            return fallback.GetStatName(stat);
        }

        /// <summary>
        /// Gets abbreviated text for stat name.
        /// </summary>
        /// <param name="stat">Stat.</param>
        /// <returns>Abbreviated text for this stat.</returns>
        public string GetAbbreviatedStatName(DFCareer.Stats stat)
        {
            return fallback.GetAbbreviatedStatName(stat);
        }

        /// <summary>
        /// Gets text resource ID of stat description.
        /// </summary>
        /// <param name="stat">Stat.</param>
        /// <returns>Text resource ID.</returns>
        public int GetStatDescriptionTextID(DFCareer.Stats stat)
        {
            return fallback.GetStatDescriptionTextID(stat);
        }

        /// <summary>
        /// Attempts to read a localized string from a named table collection.
        /// </summary>
        /// <param name="collection">Name of table collection.</param>
        /// <param name="id">ID of string to get.</param>
        /// <param name="result">Localized string result or null/empty.</param>
        /// <returns>True if string found, otherwise false.</returns>
        public bool GetLocalizedString(string collection, string id, out string result)
        {
            result = string.Empty;
            if (string.IsNullOrEmpty(collection))
            {
                return false;
            }

            var sd = LocalizationSettings.StringDatabase;
            var op = sd.GetTableAsync(collection);
            StringTable table = op.Result;

            if (table != null)
            {
                var entry = table.GetEntry(id);
                if (entry != null)
                {
                    result = entry.GetLocalizedString();
                    return true;
                }
            }

            return fallback.GetLocalizedString(collection, id, out result);
        }

        /// <summary>
        /// Enable or disable verbose localized string debug in player log.
        /// </summary>
        /// <param name="enable">True to enable, false to disable.</param>
        public void EnableLocalizedStringDebug(bool enable)
        {
            fallback.EnableLocalizedStringDebug(enable);
        }
    }
}
