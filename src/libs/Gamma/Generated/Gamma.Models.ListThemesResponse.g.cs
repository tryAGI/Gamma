
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListThemesResponse
    {
        /// <summary>
        /// Array of theme items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Gamma.ThemeItem> Data { get; set; }

        /// <summary>
        /// Whether more results exist beyond this page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Cursor for fetching the next page (null if no more results)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListThemesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of theme items
        /// </param>
        /// <param name="hasMore">
        /// Whether more results exist beyond this page
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page (null if no more results)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListThemesResponse(
            global::System.Collections.Generic.IList<global::Gamma.ThemeItem> data,
            bool hasMore,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListThemesResponse" /> class.
        /// </summary>
        public ListThemesResponse()
        {
        }

    }
}