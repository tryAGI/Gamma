
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeaderFooter
    {
        /// <summary>
        /// Element in top-left position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topLeft")]
        public global::Gamma.HeaderFooterElement? TopLeft { get; set; }

        /// <summary>
        /// Element in top-center position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topCenter")]
        public global::Gamma.HeaderFooterElement? TopCenter { get; set; }

        /// <summary>
        /// Element in top-right position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topRight")]
        public global::Gamma.HeaderFooterElement? TopRight { get; set; }

        /// <summary>
        /// Element in bottom-left position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottomLeft")]
        public global::Gamma.HeaderFooterElement? BottomLeft { get; set; }

        /// <summary>
        /// Element in bottom-center position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottomCenter")]
        public global::Gamma.HeaderFooterElement? BottomCenter { get; set; }

        /// <summary>
        /// Element in bottom-right position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottomRight")]
        public global::Gamma.HeaderFooterElement? BottomRight { get; set; }

        /// <summary>
        /// Hide header/footer from the first card (title card)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideFromFirstCard")]
        public bool? HideFromFirstCard { get; set; }

        /// <summary>
        /// Hide header/footer from the last card
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideFromLastCard")]
        public bool? HideFromLastCard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderFooter" /> class.
        /// </summary>
        /// <param name="topLeft">
        /// Element in top-left position
        /// </param>
        /// <param name="topCenter">
        /// Element in top-center position
        /// </param>
        /// <param name="topRight">
        /// Element in top-right position
        /// </param>
        /// <param name="bottomLeft">
        /// Element in bottom-left position
        /// </param>
        /// <param name="bottomCenter">
        /// Element in bottom-center position
        /// </param>
        /// <param name="bottomRight">
        /// Element in bottom-right position
        /// </param>
        /// <param name="hideFromFirstCard">
        /// Hide header/footer from the first card (title card)
        /// </param>
        /// <param name="hideFromLastCard">
        /// Hide header/footer from the last card
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeaderFooter(
            global::Gamma.HeaderFooterElement? topLeft,
            global::Gamma.HeaderFooterElement? topCenter,
            global::Gamma.HeaderFooterElement? topRight,
            global::Gamma.HeaderFooterElement? bottomLeft,
            global::Gamma.HeaderFooterElement? bottomCenter,
            global::Gamma.HeaderFooterElement? bottomRight,
            bool? hideFromFirstCard,
            bool? hideFromLastCard)
        {
            this.TopLeft = topLeft;
            this.TopCenter = topCenter;
            this.TopRight = topRight;
            this.BottomLeft = bottomLeft;
            this.BottomCenter = bottomCenter;
            this.BottomRight = bottomRight;
            this.HideFromFirstCard = hideFromFirstCard;
            this.HideFromLastCard = hideFromLastCard;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderFooter" /> class.
        /// </summary>
        public HeaderFooter()
        {
        }
    }
}