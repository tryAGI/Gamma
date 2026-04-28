
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Controls the amount of text generated per card
    /// </summary>
    public enum TextOptionsAmount
    {
        /// <summary>
        /// 
        /// </summary>
        Brief,
        /// <summary>
        /// 
        /// </summary>
        Detailed,
        /// <summary>
        /// 
        /// </summary>
        Extensive,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextOptionsAmountExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextOptionsAmount value)
        {
            return value switch
            {
                TextOptionsAmount.Brief => "brief",
                TextOptionsAmount.Detailed => "detailed",
                TextOptionsAmount.Extensive => "extensive",
                TextOptionsAmount.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextOptionsAmount? ToEnum(string value)
        {
            return value switch
            {
                "brief" => TextOptionsAmount.Brief,
                "detailed" => TextOptionsAmount.Detailed,
                "extensive" => TextOptionsAmount.Extensive,
                "medium" => TextOptionsAmount.Medium,
                _ => null,
            };
        }
    }
}