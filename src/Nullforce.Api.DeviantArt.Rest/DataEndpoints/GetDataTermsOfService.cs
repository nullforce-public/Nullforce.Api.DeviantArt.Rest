using Flurl;

namespace Nullforce.Api.DeviantArt.Rest.DataEndpoints
{
    /// <summary>
    /// Returns the DeviantArt Terms of Service
    /// </summary>
    public class GetDataTermsOfService : RestBase
    {
        public GetDataTermsOfService(string apiBaseUri)
        {
            _uri = apiBaseUri.AppendPathSegment("/data/tos");
        }
    }
}
