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
    public class BackgroundTextProvider : FallbackTextProvider
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

        Dictionary<int, TextFile.Token[]> customTokens = new Dictionary<int, TextFile.Token[]>();

        public BackgroundTextProvider(ITextProvider fallbackProvider)
            : base(fallbackProvider)
        {
            BackgroundBackstoryTokens.RegisterTokens(customTokens);
            BackgroundMiscTokens.RegisterTokens(customTokens);
        }

        /// <summary>
        /// Gets tokens from a TEXT.RSC record.
        /// </summary>
        /// <param name="id">Text resource ID.</param>
        /// <returns>Text resource tokens.</returns>
        public override TextFile.Token[] GetRSCTokens(int id)
        {
            TextFile.Token[] backgroundTokens;
            if (customTokens.TryGetValue(id, out backgroundTokens))
                return backgroundTokens;

            return FallbackProvider.GetRSCTokens(id);
        }

        /// <summary>
        /// Attempts to read a localized string from a named table collection.
        /// </summary>
        /// <param name="collection">Name of table collection.</param>
        /// <param name="id">ID of string to get.</param>
        /// <param name="result">Localized string result or null/empty.</param>
        /// <returns>True if string found, otherwise false.</returns>
        public override bool GetLocalizedString(string collection, string id, out string result)
        {
            result = string.Empty;
            if (string.IsNullOrEmpty(collection))
            {
                return false;
            }

            var sd = LocalizationSettings.StringDatabase;
            var op = sd.GetTableAsync(collection);
            op.WaitForCompletion();
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

            return FallbackProvider.GetLocalizedString(collection, id, out result);
        }
    }
}
