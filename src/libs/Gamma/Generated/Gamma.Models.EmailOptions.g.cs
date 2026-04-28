
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailOptions
    {
        /// <summary>
        /// Permission level for email recipients
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.EmailOptionsAccessJsonConverter))]
        public global::Gamma.EmailOptionsAccess? Access { get; set; }

        /// <summary>
        /// Email addresses to share with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailOptions" /> class.
        /// </summary>
        /// <param name="recipients">
        /// Email addresses to share with
        /// </param>
        /// <param name="access">
        /// Permission level for email recipients
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailOptions(
            global::System.Collections.Generic.IList<string> recipients,
            global::Gamma.EmailOptionsAccess? access)
        {
            this.Access = access;
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailOptions" /> class.
        /// </summary>
        public EmailOptions()
        {
        }
    }
}