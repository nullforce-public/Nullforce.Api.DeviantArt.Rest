using Newtonsoft.Json;

namespace Nullforce.Api.DeviantArt.Rest.Models
{
    public class GetGalleryFolderListResponse : PagedResponse<GetGalleryFolderListItem>
    {
    }

    public class GetGalleryFolderListItem
    {
        public string FolderId { get; set; }
        [JsonProperty("parent")]
        public string ParentFolderId { get; set; }
        public string Name { get; set; }
        public int Size { get; set; } = -1;
        public Deviation[] Deviations { get; set; }
    }
}
