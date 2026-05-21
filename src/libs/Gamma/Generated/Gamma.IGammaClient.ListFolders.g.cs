#nullable enable

namespace Gamma
{
    public partial interface IGammaClient
    {
        /// <summary>
        /// List folders<br/>
        /// Lists all folders the authenticated user is a member of within the workspace.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gamma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gamma.ListFoldersResponse> ListFoldersAsync(
            string? query = default,
            double? limit = default,
            string? after = default,
            global::Gamma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List folders<br/>
        /// Lists all folders the authenticated user is a member of within the workspace.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gamma.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gamma.AutoSDKHttpResponse<global::Gamma.ListFoldersResponse>> ListFoldersAsResponseAsync(
            string? query = default,
            double? limit = default,
            string? after = default,
            global::Gamma.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}