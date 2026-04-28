
#nullable enable

namespace Gamma
{
    /// <summary>
    /// How to split content across cards
    /// </summary>
    public enum GenerationCardSplit
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        InputTextBreaks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationCardSplitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationCardSplit value)
        {
            return value switch
            {
                GenerationCardSplit.Auto => "auto",
                GenerationCardSplit.InputTextBreaks => "inputTextBreaks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationCardSplit? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerationCardSplit.Auto,
                "inputTextBreaks" => GenerationCardSplit.InputTextBreaks,
                _ => null,
            };
        }
    }
}