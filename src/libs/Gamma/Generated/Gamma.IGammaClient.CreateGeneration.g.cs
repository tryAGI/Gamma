#nullable enable

namespace Gamma
{
    public partial interface IGammaClient
    {
        /// <summary>
        /// Create async generation<br/>
        /// Creates an asynchronous generation job from provided text input. Returns a generation ID that can be used to poll for status.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gamma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gamma.CreateGenerationResponse> CreateGenerationAsync(

            global::Gamma.Generation request,
            global::Gamma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create async generation<br/>
        /// Creates an asynchronous generation job from provided text input. Returns a generation ID that can be used to poll for status.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gamma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gamma.AutoSDKHttpResponse<global::Gamma.CreateGenerationResponse>> CreateGenerationAsResponseAsync(

            global::Gamma.Generation request,
            global::Gamma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create async generation<br/>
        /// Creates an asynchronous generation job from provided text input. Returns a generation ID that can be used to poll for status.
        /// </summary>
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
        /// <param name="inputText">
        /// The text content to generate from (topic, outline, or full content)
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gamma.CreateGenerationResponse> CreateGenerationAsync(
            string inputText,
            global::Gamma.GenerationTextMode? textMode = default,
            global::Gamma.GenerationFormat? format = default,
            global::Gamma.GenerationCardSplit? cardSplit = default,
            global::Gamma.GenerationExportAs? exportAs = default,
            string? additionalInstructions = default,
            double? numCards = default,
            string? themeId = default,
            global::Gamma.TextOptions? textOptions = default,
            global::Gamma.ImageOptions? imageOptions = default,
            global::Gamma.CardOptions? cardOptions = default,
            global::Gamma.SharingOptions? sharingOptions = default,
            global::System.Collections.Generic.IList<string>? folderIds = default,
            global::Gamma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}