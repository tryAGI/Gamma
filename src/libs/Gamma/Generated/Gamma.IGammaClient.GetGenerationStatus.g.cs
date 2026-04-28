#nullable enable

namespace Gamma
{
    public partial interface IGammaClient
    {
        /// <summary>
        /// Get generation status<br/>
        /// Retrieves the current status of a generation job. Poll this endpoint until status is "completed" or "failed".
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gamma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gamma.GenerationStatusResponse> GetGenerationStatusAsync(
            string id,
            global::Gamma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}