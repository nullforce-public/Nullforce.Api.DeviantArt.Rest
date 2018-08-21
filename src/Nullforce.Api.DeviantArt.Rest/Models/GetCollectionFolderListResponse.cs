using Newtonsoft.Json;

namespace Nullforce.Api.DeviantArt.Rest.Models
{
    public class GetCollectionFolderListResponse : PagedResponse<GetCollectionFolderListItem>
    {
    }

    public class GetCollectionFolderListItem
    {
        public string FolderId { get; set; }
        public string Name { get; set; }
        public int Size { get; set; } = -1;
        public Deviation[] Deviations { get; set; }
    }
}
