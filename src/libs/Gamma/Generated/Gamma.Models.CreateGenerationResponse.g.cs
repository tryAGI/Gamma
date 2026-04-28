
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerationResponse
    {
        /// <summary>
        /// Unique identifier for the generation job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// Warnings about the request (e.g., ignored parameters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public string? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerationResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// Unique identifier for the generation job
        /// </param>
        /// <param name="warnings">
        /// Warnings about the request (e.g., ignored parameters)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerationResponse(
            string generationId,
            string? warnings)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerationResponse" /> class.
        /// </summary>
        public CreateGenerationResponse()
        {
        }
    }
}