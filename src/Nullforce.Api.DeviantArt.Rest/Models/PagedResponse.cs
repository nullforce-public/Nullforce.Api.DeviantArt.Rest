using Newtonsoft.Json;

namespace Nullforce.Api.DeviantArt.Rest.Models
{
    public class PagedResponse<T> where T : class
    {
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
        [JsonProperty("next_offset")]
        public int? NextOffset { get; set; }
        // Used in: GET /gallery/folder/{folderid}
        public string Name { get; set; }

        public T[] Results { get; set; }
    }
}
