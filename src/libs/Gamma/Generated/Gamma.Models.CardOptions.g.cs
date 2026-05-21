
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CardOptions
    {
        /// <summary>
        /// Card aspect ratio/dimensions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.CardOptionsDimensionsJsonConverter))]
        public global::Gamma.CardOptionsDimensions? Dimensions { get; set; }

        /// <summary>
        /// Header and footer configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headerFooter")]
        public global::Gamma.HeaderFooter? HeaderFooter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CardOptions" /> class.
        /// </summary>
        /// <param name="dimensions">
        /// Card aspect ratio/dimensions
        /// </param>
        /// <param name="headerFooter">
        /// Header and footer configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CardOptions(
            global::Gamma.CardOptionsDimensions? dimensions,
            global::Gamma.HeaderFooter? headerFooter)
        {
            this.Dimensions = dimensions;
            this.HeaderFooter = headerFooter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardOptions" /> class.
        /// </summary>
        public CardOptions()
        {
        }

    }
}