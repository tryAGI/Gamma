
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Output format for the generated Gamma
    /// </summary>
    public enum GenerationFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Presentation,
        /// <summary>
        /// 
        /// </summary>
        Social,
        /// <summary>
        /// 
        /// </summary>
        Webpage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationFormat value)
        {
            return value switch
            {
                GenerationFormat.Document => "document",
                GenerationFormat.Presentation => "presentation",
                GenerationFormat.Social => "social",
                GenerationFormat.Webpage => "webpage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationFormat? ToEnum(string value)
        {
            return value switch
            {
                "document" => GenerationFormat.Document,
                "presentation" => GenerationFormat.Presentation,
                "social" => GenerationFormat.Social,
                "webpage" => GenerationFormat.Webpage,
                _ => null,
            };
        }
    }
}