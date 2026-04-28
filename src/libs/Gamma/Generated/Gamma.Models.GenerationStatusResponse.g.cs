
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationStatusResponse
    {
        /// <summary>
        /// Unique identifier for the generation job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// Current status of the generation job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Status { get; set; }

        /// <summary>
        /// File ID of the generated Gamma (when completed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gammaId")]
        public string? GammaId { get; set; }

        /// <summary>
        /// URL to the generated Gamma (when completed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gammaUrl")]
        public string? GammaUrl { get; set; }

        /// <summary>
        /// Error details (when failed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Gamma.ErrorResponse? Error { get; set; }

        /// <summary>
        /// URL to download exported file (when exportAs was specified)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportUrl")]
        public string? ExportUrl { get; set; }

        /// <summary>
        /// Credit usage information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public global::Gamma.CreditsResponse? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// Unique identifier for the generation job
        /// </param>
        /// <param name="status">
        /// Current status of the generation job
        /// </param>
        /// <param name="gammaId">
        /// File ID of the generated Gamma (when completed)
        /// </param>
        /// <param name="gammaUrl">
        /// URL to the generated Gamma (when completed)
        /// </param>
        /// <param name="error">
        /// Error details (when failed)
        /// </param>
        /// <param name="exportUrl">
        /// URL to download exported file (when exportAs was specified)
        /// </param>
        /// <param name="credits">
        /// Credit usage information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationStatusResponse(
            string generationId,
            object status,
            string? gammaId,
            string? gammaUrl,
            global::Gamma.ErrorResponse? error,
            string? exportUrl,
            global::Gamma.CreditsResponse? credits)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.GammaId = gammaId;
            this.GammaUrl = gammaUrl;
            this.Error = error;
            this.ExportUrl = exportUrl;
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResponse" /> class.
        /// </summary>
        public GenerationStatusResponse()
        {
        }
    }
}