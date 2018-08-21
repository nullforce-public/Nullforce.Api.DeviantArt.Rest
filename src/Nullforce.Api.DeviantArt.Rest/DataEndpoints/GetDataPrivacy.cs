using Flurl;

namespace Nullforce.Api.DeviantArt.Rest.DataEndpoints
{
    /// <summary>
    /// Returns the DeviantArt Privacy Policy
    /// </summary>
    public class GetDataPrivacy : RestBase
    {
        public GetDataPrivacy(string apiBaseUri)
        {
            _uri = apiBaseUri.AppendPathSegment("/data/privacy");
        }
    }
}
