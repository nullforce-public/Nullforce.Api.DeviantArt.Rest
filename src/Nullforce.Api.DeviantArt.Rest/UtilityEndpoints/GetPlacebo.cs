using Flurl;

namespace Nullforce.Api.DeviantArt.Rest.UtilityEndpoints
{
    public class GetPlacebo : RestBase
    {
        public GetPlacebo(string apiBaseUri)
        {
            _uri = apiBaseUri.AppendPathSegment("/placebo");
        }

        public GetPlacebo WithMatureContent(bool includeMature = true)
        {
            _uri = _uri.SetQueryParam("mature_content", includeMature);
            return this;
        }
    }
}
