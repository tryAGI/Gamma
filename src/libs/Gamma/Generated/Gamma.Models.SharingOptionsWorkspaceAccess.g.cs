
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Default access level for workspace members
    /// </summary>
    public enum SharingOptionsWorkspaceAccess
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
        NoAccess,
        /// <summary>
        /// 
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SharingOptionsWorkspaceAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharingOptionsWorkspaceAccess value)
        {
            return value switch
            {
                SharingOptionsWorkspaceAccess.Comment => "comment",
                SharingOptionsWorkspaceAccess.Edit => "edit",
                SharingOptionsWorkspaceAccess.FullAccess => "fullAccess",
                SharingOptionsWorkspaceAccess.NoAccess => "noAccess",
                SharingOptionsWorkspaceAccess.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharingOptionsWorkspaceAccess? ToEnum(string value)
        {
            return value switch
            {
                "comment" => SharingOptionsWorkspaceAccess.Comment,
                "edit" => SharingOptionsWorkspaceAccess.Edit,
                "fullAccess" => SharingOptionsWorkspaceAccess.FullAccess,
                "noAccess" => SharingOptionsWorkspaceAccess.NoAccess,
                "view" => SharingOptionsWorkspaceAccess.View,
                _ => null,
            };
        }
    }
}