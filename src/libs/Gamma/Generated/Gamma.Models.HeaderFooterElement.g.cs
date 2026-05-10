
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeaderFooterElement
    {
        /// <summary>
        /// Type of element to display
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Image source type (required when type is "image")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public object? Source { get; set; }

        /// <summary>
        /// Custom image URL (required when source is "custom")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// Text content (required when type is "text")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Size of the image element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public object? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderFooterElement" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of element to display
        /// </param>
        /// <param name="source">
        /// Image source type (required when type is "image")
        /// </param>
        /// <param name="src">
        /// Custom image URL (required when source is "custom")
        /// </param>
        /// <param name="value">
        /// Text content (required when type is "text")
        /// </param>
        /// <param name="size">
        /// Size of the image element
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeaderFooterElement(
            object type,
            object? source,
            string? src,
            string? value,
            object? size)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Source = source;
            this.Src = src;
            this.Value = value;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderFooterElement" /> class.
        /// </summary>
        public HeaderFooterElement()
        {
        }

    }
}