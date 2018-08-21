using Flurl;

namespace Nullforce.Api.DeviantArt.Rest.DeviationEndpoints
{
    /// <summary>
    /// Get the original file download (if allowed)
    /// </summary>
    public class GetDeviationDownload : RestBase, IMatureContent<GetDeviationDownload>
    {
        public GetDeviationDownload(string apiBaseUri, string deviationId)
        {
            _uri = apiBaseUri.AppendPathSegment($"/deviation/download/{deviationId}");
        }

        public GetDeviationDownload WithMatureContent(bool allowMature = true)
        {
            _uri = _uri.SetQueryParam("mature_content", allowMature ? "true" : "false");
            return this;
        }
    }
}
