
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageOptions
    {
        /// <summary>
        /// AI model to use for image generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.ImageModelJsonConverter))]
        public global::Gamma.ImageModel? Model { get; set; }

        /// <summary>
        /// Source for images: AI-generated or web search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.ImageOptionsSourceJsonConverter))]
        public global::Gamma.ImageOptionsSource? Source { get; set; }

        /// <summary>
        /// Style description for AI-generated images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageOptions" /> class.
        /// </summary>
        /// <param name="model">
        /// AI model to use for image generation
        /// </param>
        /// <param name="source">
        /// Source for images: AI-generated or web search
        /// </param>
        /// <param name="style">
        /// Style description for AI-generated images
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageOptions(
            global::Gamma.ImageModel? model,
            global::Gamma.ImageOptionsSource? source,
            string? style)
        {
            this.Model = model;
            this.Source = source;
            this.Style = style;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageOptions" /> class.
        /// </summary>
        public ImageOptions()
        {
        }
    }
}