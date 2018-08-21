using Flurl;

namespace Nullforce.Api.DeviantArt.Rest.DeviationEndpoints
{
    /// <summary>
    /// Fetch a deviation
    /// </summary>
    public class GetDeviation : RestBase
    {
        public GetDeviation(string apiBaseUri, string deviationId)
        {
            _uri = apiBaseUri.AppendPathSegment($"/deviation/{deviationId}");
        }
    }
}
