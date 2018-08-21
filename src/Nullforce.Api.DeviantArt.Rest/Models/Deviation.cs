using Newtonsoft.Json;

namespace Nullforce.Api.DeviantArt.Rest.Models
{
    public class Deviation
    {
        public string DeviationId { get; set; }
        public string PrintId { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        [JsonProperty("category_path")]
        public string CategoryPath { get; set; }
        [JsonProperty("is_favourited")]
        public bool IsFavorite { get; set; } = false;
        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }
        public User Author { get; set; }
        public DeviationStats Stats { get; set; }
        [JsonProperty("published_time")]
        public int PublishedTime { get; set; }
        [JsonProperty("allows_comments")]
        public bool AllowsComments { get; set; }
        public DeviationPreview Preview { get; set; }
        public DeviationContent Content { get; set; }
        [JsonProperty("thumbs")]
        public DeviationThumbnail[] Thumbnails { get; set; }
        public DeviationVideo[] Videos { get; set; }
        public DeviationFlash Flash { get; set; }
        [JsonProperty("daily_deviation")]
        public DeviationDaily DailyDeviation { get; set; }
        public string Excerpt { get; set; }
        [JsonProperty("is_mature")]
        public bool IsMature { get; set; } = false;
        [JsonProperty("is_downloadable")]
        public bool IsDownloadable { get; set; } = false;
        [JsonProperty("download_filesize")]
        public int DownloadFileSize { get; set; } = 0;
        public DeviationChallenge Challenge { get; set; }
        [JsonProperty("challenge_entry")]
        public DeviationChallengeEntry ChallengeEntry { get; set; }
        [JsonProperty("motion_book")]
        public DeviationMotionBook MotionBook { get; set; }
    }

    public class DeviationStats
    {
        public int Comments { get; set; }
        [JsonProperty("favourites")]
        public int Favorites { get; set; }
    }

    public class DeviationPreview
    {
        [JsonProperty("src")]
        public string Source { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool Transparency { get; set; }
    }

    public class DeviationContent
    {
        [JsonProperty("src")]
        public string Source { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool Transparency { get; set; }
        public int FileSize { get; set; }
    }

    public class DeviationThumbnail
    {
        [JsonProperty("src")]
        public string Source { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool Transparency { get; set; }
    }

    public class DeviationVideo
    {
        [JsonProperty("src")]
        public string Source { get; set; }
        public string Quality { get; set; }
        public int FileSize { get; set; }
        public int Duration { get; set; }
    }

    public class DeviationFlash
    {
        [JsonProperty("src")]
        public string Source { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }

    public class DeviationDaily
    {
        public string Body { get; set; }
        public string Time { get; set; }
        public User Giver { get; set; }
        public User Suggester { get; set; }
    }

    public class DeviationChallenge
    {
        public string[] Type { get; set; }
        public bool Completed { get; set; }
        public string[] Tags { get; set; }
        public bool Locked { get; set; } = false;
        [JsonProperty("credit_deviation")]
        public string CreditDeviationId { get; set; }
        public string[] Media { get; set; }
        [JsonProperty("level_label")]
        public string LevelLabel { get; set; }
        [JsonProperty("time_limit")]
        public int TimeLimit { get; set; } = 0;
        public string[] Levels { get; set; }
    }

    public class DeviationChallengeEntry
    {
        public string ChallengeId { get; set; }
        [JsonProperty("challenge_title")]
        public string ChallengeTitle { get; set; }
        public Deviation Challenge { get; set; }
        [JsonProperty("timed_duration")]
        public int TimedDuration { get; set; }
        [JsonProperty("submission_time")]
        public string SubmissionTime { get; set; }
    }

    public class DeviationMotionBook
    {
        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }
    }
}
