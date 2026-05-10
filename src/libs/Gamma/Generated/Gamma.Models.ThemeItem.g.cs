
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThemeItem
    {
        /// <summary>
        /// Unique theme identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the theme
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Keywords describing the theme's color palette
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colorKeywords")]
        public global::System.Collections.Generic.IList<string>? ColorKeywords { get; set; }

        /// <summary>
        /// Keywords describing the theme's tone/style
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toneKeywords")]
        public global::System.Collections.Generic.IList<string>? ToneKeywords { get; set; }

        /// <summary>
        /// Theme type: standard (built-in) or custom (workspace-created)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique theme identifier
        /// </param>
        /// <param name="name">
        /// Display name of the theme
        /// </param>
        /// <param name="type">
        /// Theme type: standard (built-in) or custom (workspace-created)
        /// </param>
        /// <param name="colorKeywords">
        /// Keywords describing the theme's color palette
        /// </param>
        /// <param name="toneKeywords">
        /// Keywords describing the theme's tone/style
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThemeItem(
            string id,
            string name,
            object type,
            global::System.Collections.Generic.IList<string>? colorKeywords,
            global::System.Collections.Generic.IList<string>? toneKeywords)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ColorKeywords = colorKeywords;
            this.ToneKeywords = toneKeywords;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeItem" /> class.
        /// </summary>
        public ThemeItem()
        {
        }

    }
}