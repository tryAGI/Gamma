
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Generation
    {
        /// <summary>
        /// How to interpret the input text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.GenerationTextModeJsonConverter))]
        public global::Gamma.GenerationTextMode? TextMode { get; set; }

        /// <summary>
        /// Output format for the generated Gamma
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.GenerationFormatJsonConverter))]
        public global::Gamma.GenerationFormat? Format { get; set; }

        /// <summary>
        /// How to split content across cards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardSplit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.GenerationCardSplitJsonConverter))]
        public global::Gamma.GenerationCardSplit? CardSplit { get; set; }

        /// <summary>
        /// Export format for automatic export after generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportAs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.GenerationExportAsJsonConverter))]
        public global::Gamma.GenerationExportAs? ExportAs { get; set; }

        /// <summary>
        /// The text content to generate from (topic, outline, or full content)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputText { get; set; }

        /// <summary>
        /// Additional instructions for the AI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalInstructions")]
        public string? AdditionalInstructions { get; set; }

        /// <summary>
        /// Target number of cards/slides to generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numCards")]
        public double? NumCards { get; set; }

        /// <summary>
        /// Theme ID to apply (from /themes endpoint)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("themeId")]
        public string? ThemeId { get; set; }

        /// <summary>
        /// Text generation options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textOptions")]
        public global::Gamma.TextOptions? TextOptions { get; set; }

        /// <summary>
        /// Image generation and selection options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageOptions")]
        public global::Gamma.ImageOptions? ImageOptions { get; set; }

        /// <summary>
        /// Card dimensions and layout options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardOptions")]
        public global::Gamma.CardOptions? CardOptions { get; set; }

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
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        /// <param name="inputText">
        /// The text content to generate from (topic, outline, or full content)
        /// </param>
        /// <param name="textMode">
        /// How to interpret the input text
        /// </param>
        /// <param name="format">
        /// Output format for the generated Gamma
        /// </param>
        /// <param name="cardSplit">
        /// How to split content across cards
        /// </param>
        /// <param name="exportAs">
        /// Export format for automatic export after generation
        /// </param>
        /// <param name="additionalInstructions">
        /// Additional instructions for the AI
        /// </param>
        /// <param name="numCards">
        /// Target number of cards/slides to generate
        /// </param>
        /// <param name="themeId">
        /// Theme ID to apply (from /themes endpoint)
        /// </param>
        /// <param name="textOptions">
        /// Text generation options
        /// </param>
        /// <param name="imageOptions">
        /// Image generation and selection options
        /// </param>
        /// <param name="cardOptions">
        /// Card dimensions and layout options
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
        public Generation(
            string inputText,
            global::Gamma.GenerationTextMode? textMode,
            global::Gamma.GenerationFormat? format,
            global::Gamma.GenerationCardSplit? cardSplit,
            global::Gamma.GenerationExportAs? exportAs,
            string? additionalInstructions,
            double? numCards,
            string? themeId,
            global::Gamma.TextOptions? textOptions,
            global::Gamma.ImageOptions? imageOptions,
            global::Gamma.CardOptions? cardOptions,
            global::Gamma.SharingOptions? sharingOptions,
            global::System.Collections.Generic.IList<string>? folderIds)
        {
            this.TextMode = textMode;
            this.Format = format;
            this.CardSplit = cardSplit;
            this.ExportAs = exportAs;
            this.InputText = inputText ?? throw new global::System.ArgumentNullException(nameof(inputText));
            this.AdditionalInstructions = additionalInstructions;
            this.NumCards = numCards;
            this.ThemeId = themeId;
            this.TextOptions = textOptions;
            this.ImageOptions = imageOptions;
            this.CardOptions = cardOptions;
            this.SharingOptions = sharingOptions;
            this.FolderIds = folderIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        public Generation()
        {
        }

    }
}