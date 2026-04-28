
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FromTemplateGeneration
    {
        /// <summary>
        /// Export format for automatic export after generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportAs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.FromTemplateGenerationExportAsJsonConverter))]
        public global::Gamma.FromTemplateGenerationExportAs? ExportAs { get; set; }

        /// <summary>
        /// Text prompt describing what to generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The File ID of the gamma to be used as a template. The File must contain exactly one Page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gammaId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GammaId { get; set; }

        /// <summary>
        /// Theme ID to apply to the generated Gamma
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("themeId")]
        public string? ThemeId { get; set; }

        /// <summary>
        /// Image generation options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageOptions")]
        public global::Gamma.FromTemplateImageOptions? ImageOptions { get; set; }

        /// <summary>
        /// Sharing and permissions options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharingOptions")]
        public global::Gamma.SharingOptions? SharingOptions { get; set; }

        /// <summary>
        /// Folder IDs to place the generated Gamma in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderIds")]
        public global::System.Collections.Generic.IList<string>? FolderIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FromTemplateGeneration" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt describing what to generate
        /// </param>
        /// <param name="gammaId">
        /// The File ID of the gamma to be used as a template. The File must contain exactly one Page.
        /// </param>
        /// <param name="exportAs">
        /// Export format for automatic export after generation
        /// </param>
        /// <param name="themeId">
        /// Theme ID to apply to the generated Gamma
        /// </param>
        /// <param name="imageOptions">
        /// Image generation options
        /// </param>
        /// <param name="sharingOptions">
        /// Sharing and permissions options
        /// </param>
        /// <param name="folderIds">
        /// Folder IDs to place the generated Gamma in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FromTemplateGeneration(
            string prompt,
            string gammaId,
            global::Gamma.FromTemplateGenerationExportAs? exportAs,
            string? themeId,
            global::Gamma.FromTemplateImageOptions? imageOptions,
            global::Gamma.SharingOptions? sharingOptions,
            global::System.Collections.Generic.IList<string>? folderIds)
        {
            this.ExportAs = exportAs;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.GammaId = gammaId ?? throw new global::System.ArgumentNullException(nameof(gammaId));
            this.ThemeId = themeId;
            this.ImageOptions = imageOptions;
            this.SharingOptions = sharingOptions;
            this.FolderIds = folderIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FromTemplateGeneration" /> class.
        /// </summary>
        public FromTemplateGeneration()
        {
        }
    }
}