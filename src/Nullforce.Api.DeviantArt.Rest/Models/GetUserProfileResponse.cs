using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nullforce.Api.DeviantArt.Rest.Models
{
    public class GetUserProfileResponse
    {
        public User User { get; set; }
        [JsonProperty("is_watching")]
        public bool IsWatching { get; set; }
        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }
        [JsonProperty("user_is_artist")]
        public bool UserIsArtist { get; set; }
        [JsonProperty("artist_level")]
        public string ArtistLevel { get; set; }
        [JsonProperty("artist_speciality")]
        public string ArtistSpecialty { get; set; }
        [JsonProperty("real_name")]
        public string RealName { get; set; }
        public string Tagline { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public string Bio { get; set; }
        [JsonProperty("cover_photo")]
        public string CoverPhoto { get; set; }
        [JsonProperty("profile_pic")]
        public Deviation ProfilePicture { get; set; }
        // last_status
        // stats
        // collections
        // galleries
    }
}
