
#nullable enable

namespace Gamma
{
    /// <summary>
    /// How to interpret the input text
    /// </summary>
    public enum GenerationTextMode
    {
        /// <summary>
        /// 
        /// </summary>
        Condense,
        /// <summary>
        /// 
        /// </summary>
        Generate,
        /// <summary>
        /// 
        /// </summary>
        Preserve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationTextModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationTextMode value)
        {
            return value switch
            {
                GenerationTextMode.Condense => "condense",
                GenerationTextMode.Generate => "generate",
                GenerationTextMode.Preserve => "preserve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationTextMode? ToEnum(string value)
        {
            return value switch
            {
                "condense" => GenerationTextMode.Condense,
                "generate" => GenerationTextMode.Generate,
                "preserve" => GenerationTextMode.Preserve,
                _ => null,
            };
        }
    }
}