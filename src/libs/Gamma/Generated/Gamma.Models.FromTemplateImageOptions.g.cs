
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FromTemplateImageOptions
    {
        /// <summary>
        /// AI model for image generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.ImageModelJsonConverter))]
        public global::Gamma.ImageModel? Model { get; set; }

        /// <summary>
        /// Style description for images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FromTemplateImageOptions" /> class.
        /// </summary>
        /// <param name="model">
        /// AI model for image generation
        /// </param>
        /// <param name="style">
        /// Style description for images
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FromTemplateImageOptions(
            global::Gamma.ImageModel? model,
            string? style)
        {
            this.Model = model;
            this.Style = style;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FromTemplateImageOptions" /> class.
        /// </summary>
        public FromTemplateImageOptions()
        {
        }
    }
}