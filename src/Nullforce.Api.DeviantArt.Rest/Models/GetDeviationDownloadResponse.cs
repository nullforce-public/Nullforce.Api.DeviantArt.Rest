using Newtonsoft.Json;

namespace Nullforce.Api.DeviantArt.Rest.Models
{
    public class GetDeviationDownloadResponse
    {
        [JsonProperty("src")]
        public string Source { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int FileSize { get; set; }
    }
}
