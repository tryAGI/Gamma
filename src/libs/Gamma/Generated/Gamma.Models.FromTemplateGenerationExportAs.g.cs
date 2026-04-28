
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Export format for automatic export after generation
    /// </summary>
    public enum FromTemplateGenerationExportAs
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
    public static class FromTemplateGenerationExportAsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FromTemplateGenerationExportAs value)
        {
            return value switch
            {
                FromTemplateGenerationExportAs.Pdf => "pdf",
                FromTemplateGenerationExportAs.Png => "png",
                FromTemplateGenerationExportAs.Pptx => "pptx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FromTemplateGenerationExportAs? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => FromTemplateGenerationExportAs.Pdf,
                "png" => FromTemplateGenerationExportAs.Png,
                "pptx" => FromTemplateGenerationExportAs.Pptx,
                _ => null,
            };
        }
    }
}