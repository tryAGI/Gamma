
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharingOptions
    {
        /// <summary>
        /// Default access level for workspace members
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceAccess")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.SharingOptionsWorkspaceAccessJsonConverter))]
        public global::Gamma.SharingOptionsWorkspaceAccess? WorkspaceAccess { get; set; }

        /// <summary>
        /// Access level for external users (via shared link)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalAccess")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.SharingOptionsExternalAccessJsonConverter))]
        public global::Gamma.SharingOptionsExternalAccess? ExternalAccess { get; set; }

        /// <summary>
        /// Email sharing configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailOptions")]
        public global::Gamma.EmailOptions? EmailOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingOptions" /> class.
        /// </summary>
        /// <param name="workspaceAccess">
        /// Default access level for workspace members
        /// </param>
        /// <param name="externalAccess">
        /// Access level for external users (via shared link)
        /// </param>
        /// <param name="emailOptions">
        /// Email sharing configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharingOptions(
            global::Gamma.SharingOptionsWorkspaceAccess? workspaceAccess,
            global::Gamma.SharingOptionsExternalAccess? externalAccess,
            global::Gamma.EmailOptions? emailOptions)
        {
            this.WorkspaceAccess = workspaceAccess;
            this.ExternalAccess = externalAccess;
            this.EmailOptions = emailOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingOptions" /> class.
        /// </summary>
        public SharingOptions()
        {
        }

    }
}