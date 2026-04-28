#nullable enable

namespace Gamma
{
    public partial interface IGammaClient
    {
        /// <summary>
        /// Create generation from template<br/>
        /// Creates an asynchronous generation job from a template Gamma with variable substitution.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gamma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gamma.FromTemplateGenerationResponse> CreateFromTemplateGenerationAsync(

            global::Gamma.FromTemplateGeneration request,
            global::Gamma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create generation from template<br/>
        /// Creates an asynchronous generation job from a template Gamma with variable substitution.
        /// </summary>
        /// <param name="exportAs">
        /// Export format for automatic export after generation
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing what to generate
        /// </param>
        /// <param name="gammaId">
        /// The File ID of the gamma to be used as a template. The File must contain exactly one Page.
        /// </param>
        /// <param name="themeId">
        /// Theme ID to apply to the generated Gamma
        /// </param>
        /// <param name="imageOptions">
        /// Image generation options
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
        global::System.Threading.Tasks.Task<global::Gamma.FromTemplateGenerationResponse> CreateFromTemplateGenerationAsync(
            string prompt,
            string gammaId,
            global::Gamma.FromTemplateGenerationExportAs? exportAs = default,
            string? themeId = default,
            global::Gamma.FromTemplateImageOptions? imageOptions = default,
            global::Gamma.SharingOptions? sharingOptions = default,
            global::System.Collections.Generic.IList<string>? folderIds = default,
            global::Gamma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}