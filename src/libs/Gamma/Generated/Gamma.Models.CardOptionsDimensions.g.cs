
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Card aspect ratio/dimensions
    /// </summary>
    public enum CardOptionsDimensions
    {
        /// <summary>
        /// 
        /// </summary>
        x16x9,
        /// <summary>
        /// 
        /// </summary>
        x1x1,
        /// <summary>
        /// 
        /// </summary>
        x4x3,
        /// <summary>
        /// 
        /// </summary>
        x4x5,
        /// <summary>
        /// 
        /// </summary>
        x9x16,
        /// <summary>
        /// 
        /// </summary>
        A4,
        /// <summary>
        /// 
        /// </summary>
        Fluid,
        /// <summary>
        /// 
        /// </summary>
        Letter,
        /// <summary>
        /// 
        /// </summary>
        Pageless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CardOptionsDimensionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CardOptionsDimensions value)
        {
            return value switch
            {
                CardOptionsDimensions.x16x9 => "16x9",
                CardOptionsDimensions.x1x1 => "1x1",
                CardOptionsDimensions.x4x3 => "4x3",
                CardOptionsDimensions.x4x5 => "4x5",
                CardOptionsDimensions.x9x16 => "9x16",
                CardOptionsDimensions.A4 => "a4",
                CardOptionsDimensions.Fluid => "fluid",
                CardOptionsDimensions.Letter => "letter",
                CardOptionsDimensions.Pageless => "pageless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CardOptionsDimensions? ToEnum(string value)
        {
            return value switch
            {
                "16x9" => CardOptionsDimensions.x16x9,
                "1x1" => CardOptionsDimensions.x1x1,
                "4x3" => CardOptionsDimensions.x4x3,
                "4x5" => CardOptionsDimensions.x4x5,
                "9x16" => CardOptionsDimensions.x9x16,
                "a4" => CardOptionsDimensions.A4,
                "fluid" => CardOptionsDimensions.Fluid,
                "letter" => CardOptionsDimensions.Letter,
                "pageless" => CardOptionsDimensions.Pageless,
                _ => null,
            };
        }
    }
}