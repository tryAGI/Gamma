
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsResponse
    {
        /// <summary>
        /// Number of credits deducted for this operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deducted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Deducted { get; set; }

        /// <summary>
        /// Remaining credits in the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Remaining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsResponse" /> class.
        /// </summary>
        /// <param name="deducted">
        /// Number of credits deducted for this operation
        /// </param>
        /// <param name="remaining">
        /// Remaining credits in the workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsResponse(
            double deducted,
            double remaining)
        {
            this.Deducted = deducted;
            this.Remaining = remaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsResponse" /> class.
        /// </summary>
        public CreditsResponse()
        {
        }
    }
}