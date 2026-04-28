
#nullable enable

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextOptions
    {
        /// <summary>
        /// Controls the amount of text generated per card
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.TextOptionsAmountJsonConverter))]
        public global::Gamma.TextOptionsAmount? Amount { get; set; }

        /// <summary>
        /// Language code for the generated content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gamma.JsonConverters.TextOptionsLanguageJsonConverter))]
        public global::Gamma.TextOptionsLanguage? Language { get; set; }

        /// <summary>
        /// The tone or writing style for the generated text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tone")]
        public string? Tone { get; set; }

        /// <summary>
        /// The target audience for the content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextOptions" /> class.
        /// </summary>
        /// <param name="amount">
        /// Controls the amount of text generated per card
        /// </param>
        /// <param name="language">
        /// Language code for the generated content
        /// </param>
        /// <param name="tone">
        /// The tone or writing style for the generated text
        /// </param>
        /// <param name="audience">
        /// The target audience for the content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextOptions(
            global::Gamma.TextOptionsAmount? amount,
            global::Gamma.TextOptionsLanguage? language,
            string? tone,
            string? audience)
        {
            this.Amount = amount;
            this.Language = language;
            this.Tone = tone;
            this.Audience = audience;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextOptions" /> class.
        /// </summary>
        public TextOptions()
        {
        }
    }
}