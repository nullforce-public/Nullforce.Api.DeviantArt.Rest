using Newtonsoft.Json;

namespace Nullforce.Api.DeviantArt.Rest.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string UserIcon { get; set; }
        public string Type { get; set; }
        [JsonProperty("is_watching")]
        public bool IsWatching { get; set; }

        // Optional
        public UserDetails Details { get; set; }
        // Optional
        public UserGeo Geo { get; set; }
        // Optional
        public UserProfile Profile { get; set; }
        // Optional
        public UserStats Stats { get; set; }
    }

    public class UserDetails
    {
        public string Sex { get; set; }
        public int? Age { get; set; }
        public string JoinDate { get; set; }
    }

    public class UserGeo
    {
        public string Country { get; set; }
        public int CountryId { get; set; }
        public string TimeZone { get; set; }
    }

    public class UserProfile
    {
        [JsonProperty("user_is_artist")]
        public bool IsArtist { get; set; }
        [JsonProperty("artist_level")]
        public string ArtistLevel { get; set; }
        [JsonProperty("artist_speciality")]
        public string ArtistSpeciality { get; set; }
        [JsonProperty("real_name")]
        public string RealName { get; set; }
        public string Tagline { get; set; }
        public string Website { get; set; }
        [JsonProperty("cover_photo")]
        public string CoverPhoto { get; set; }
        [JsonProperty("profile_pic")]
        public Deviation ProfilePicture { get; set; }
    }

    public class UserStats
    {
        public int Watchers { get; set; }
        public int Friends { get; set; }
    }
}
