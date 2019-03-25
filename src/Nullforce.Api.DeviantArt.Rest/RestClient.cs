using Nullforce.Api.DeviantArt.Rest.CollectionEndpoints;
using Nullforce.Api.DeviantArt.Rest.DeviationEndpoints;
using Nullforce.Api.DeviantArt.Rest.GalleryEndpoints;
using Nullforce.Api.DeviantArt.Rest.UserEndpoints;
using Nullforce.Api.DeviantArt.Rest.UtilityEndpoints;

namespace Nullforce.Api.DeviantArt.Rest
{
    public class RestClient
    {
        // https://www.deviantart.com/developers/

        private readonly string _apiBaseUri = "https://www.deviantart.com/api/v1/oauth2";
        private readonly string _clientId;
        private readonly string _clientSecret;

        public RestClient(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public RestClient()
        {
        }

        public GetCollectionFolder GetCollectionFolder(string folderId)
        {
            return new GetCollectionFolder(_apiBaseUri, folderId);
        }

        public GetCollectionFolderList GetCollectionFolderList()
        {
            return new GetCollectionFolderList(_apiBaseUri);
        }

        public GetDeviation GetDeviation(string deviationId)
        {
            return new GetDeviation(_apiBaseUri, deviationId);
        }

        public GetDeviationDownload GetDeviationDownload(string deviationId)
        {
            return new GetDeviationDownload(_apiBaseUri, deviationId);
        }

        public GetDeviationMetadata GetDeviationMetadata(string deviationId)
        {
            return new GetDeviationMetadata(_apiBaseUri, deviationId);
        }

        public GetDeviationMetadata GetDeviationMetadata(string[] deviationIds)
        {
            return new GetDeviationMetadata(_apiBaseUri, deviationIds);
        }

        public GetGalleryAll GetGetGalleryAll()
        {
            return new GetGalleryAll(_apiBaseUri);
        }

        /// <summary>
        /// Fetch gallery folder contents
        /// </summary>
        public GetGalleryFolder GetGalleryFolder()
        {
            return new GetGalleryFolder(_apiBaseUri);
        }

        /// <summary>
        /// Fetch gallery folder contents
        /// </summary>
        public GetGalleryFolder GetGalleryFolder(string folderId)
        {
            return new GetGalleryFolder(_apiBaseUri, folderId);
        }

        public GetGalleryFolderList GetGalleryFolderList()
        {
            return new GetGalleryFolderList(_apiBaseUri);
        }

        public GetUserFriendList GetUserFriendList(string username)
        {
            return new GetUserFriendList(_apiBaseUri, username);
        }

        public GetUserProfile GetUserProfile(string username)
        {
            return new GetUserProfile(_apiBaseUri, username);
        }

        public GetPlacebo GetPlacebo()
        {
            return new GetPlacebo(_apiBaseUri);
        }
    }
}
