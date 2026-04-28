
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Export format for automatic export after generation
    /// </summary>
    public enum GenerationExportAs
    {
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Pptx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationExportAs value)
        {
            return value switch
            {
                GenerationExportAs.Pdf => "pdf",
                GenerationExportAs.Png => "png",
                GenerationExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => GenerationExportAs.Pdf,
                "png" => GenerationExportAs.Png,
                "pptx" => GenerationExportAs.Pptx,
                _ => null,
            };
        }
    }
}