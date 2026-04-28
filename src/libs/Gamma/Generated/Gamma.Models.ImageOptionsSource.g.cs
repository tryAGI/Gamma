
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Source for images: AI-generated or web search
    /// </summary>
    public enum ImageOptionsSource
    {
        /// <summary>
        /// 
        /// </summary>
        AiGenerated,
        /// <summary>
        /// 
        /// </summary>
        Giphy,
        /// <summary>
        /// 
        /// </summary>
        NoImages,
        /// <summary>
        /// 
        /// </summary>
        Pexels,
        /// <summary>
        /// 
        /// </summary>
        Pictographic,
        /// <summary>
        /// 
        /// </summary>
        Placeholder,
        /// <summary>
        /// 
        /// </summary>
        ThemeAccent,
        /// <summary>
        /// 
        /// </summary>
        WebAllImages,
        /// <summary>
        /// 
        /// </summary>
        WebFreeToUse,
        /// <summary>
        /// 
        /// </summary>
        WebFreeToUseCommercially,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageOptionsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageOptionsSource value)
        {
            return value switch
            {
                ImageOptionsSource.AiGenerated => "aiGenerated",
                ImageOptionsSource.Giphy => "giphy",
                ImageOptionsSource.NoImages => "noImages",
                ImageOptionsSource.Pexels => "pexels",
                ImageOptionsSource.Pictographic => "pictographic",
                ImageOptionsSource.Placeholder => "placeholder",
                ImageOptionsSource.ThemeAccent => "themeAccent",
                ImageOptionsSource.WebAllImages => "webAllImages",
                ImageOptionsSource.WebFreeToUse => "webFreeToUse",
                ImageOptionsSource.WebFreeToUseCommercially => "webFreeToUseCommercially",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageOptionsSource? ToEnum(string value)
        {
            return value switch
            {
                "aiGenerated" => ImageOptionsSource.AiGenerated,
                "giphy" => ImageOptionsSource.Giphy,
                "noImages" => ImageOptionsSource.NoImages,
                "pexels" => ImageOptionsSource.Pexels,
                "pictographic" => ImageOptionsSource.Pictographic,
                "placeholder" => ImageOptionsSource.Placeholder,
                "themeAccent" => ImageOptionsSource.ThemeAccent,
                "webAllImages" => ImageOptionsSource.WebAllImages,
                "webFreeToUse" => ImageOptionsSource.WebFreeToUse,
                "webFreeToUseCommercially" => ImageOptionsSource.WebFreeToUseCommercially,
                _ => null,
            };
        }
    }
}