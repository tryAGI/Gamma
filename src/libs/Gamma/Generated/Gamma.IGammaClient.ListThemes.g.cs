#nullable enable

namespace Gamma
{
    public partial interface IGammaClient
    {
        /// <summary>
        /// List themes<br/>
        /// Lists all themes available to the workspace, including standard themes and custom workspace themes.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gamma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gamma.ListThemesResponse> ListThemesAsync(
            string? query = default,
            double? limit = default,
            string? after = default,
            global::Gamma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}