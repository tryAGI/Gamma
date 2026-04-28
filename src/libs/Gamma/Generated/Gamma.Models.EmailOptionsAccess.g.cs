
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Permission level for email recipients
    /// </summary>
    public enum EmailOptionsAccess
    {
        /// <summary>
        /// 
        /// </summary>
        Comment,
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        FullAccess,
        /// <summary>
        /// 
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailOptionsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailOptionsAccess value)
        {
            return value switch
            {
                EmailOptionsAccess.Comment => "comment",
                EmailOptionsAccess.Edit => "edit",
                EmailOptionsAccess.FullAccess => "fullAccess",
                EmailOptionsAccess.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailOptionsAccess? ToEnum(string value)
        {
            return value switch
            {
                "comment" => EmailOptionsAccess.Comment,
                "edit" => EmailOptionsAccess.Edit,
                "fullAccess" => EmailOptionsAccess.FullAccess,
                "view" => EmailOptionsAccess.View,
                _ => null,
            };
        }
    }
}