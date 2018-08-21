using Newtonsoft.Json;

namespace Nullforce.Api.DeviantArt.Rest.Models
{
    public class GetUserFriendListResponse : PagedResponse<UserFriend>
    {
    }

    public class UserFriend
    {
        public User User { get; set; }
        [JsonProperty("is_watching")]
        public bool IsWatching { get; set; }
        [JsonProperty("watches_you")]
        public bool WatchesYou { get; set; }
        public string LastVisit { get; set; }
        public Watch Watch { get; set; }
    }

    public class Watch
    {
        public bool Friend { get; set; }
        public bool Deviations { get; set; }
        public bool Journals { get; set; }
        [JsonProperty("forum_threads")]
        public bool ForumThreads { get; set; }
        public bool Critiques { get; set; }
        public bool Scraps { get; set; }
        public bool Activity { get; set; }
        public bool Collections { get; set; }
    }
}
