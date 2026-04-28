
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Access level for external users (via shared link)
    /// </summary>
    public enum SharingOptionsExternalAccess
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
        NoAccess,
        /// <summary>
        /// 
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SharingOptionsExternalAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharingOptionsExternalAccess value)
        {
            return value switch
            {
                SharingOptionsExternalAccess.Comment => "comment",
                SharingOptionsExternalAccess.Edit => "edit",
                SharingOptionsExternalAccess.NoAccess => "noAccess",
                SharingOptionsExternalAccess.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharingOptionsExternalAccess? ToEnum(string value)
        {
            return value switch
            {
                "comment" => SharingOptionsExternalAccess.Comment,
                "edit" => SharingOptionsExternalAccess.Edit,
                "noAccess" => SharingOptionsExternalAccess.NoAccess,
                "view" => SharingOptionsExternalAccess.View,
                _ => null,
            };
        }
    }
}