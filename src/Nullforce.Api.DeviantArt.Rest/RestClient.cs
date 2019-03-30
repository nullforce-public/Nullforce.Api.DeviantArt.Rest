using Nullforce.Api.DeviantArt.Rest.BrowseEndpoints;
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

        // Browse Endpoints

        /// <summary>
        /// Fetch category information for browsing
        /// </summary>
        /// <param name="categoryPath"></param>
        /// <returns></returns>
        public GetBrowseCategoryTree GetGetBrowseCategoryTree(string categoryPath)
        {
            return new GetBrowseCategoryTree(_apiBaseUri, categoryPath);
        }

        /// <summary>
        /// Browse daily deviations
        /// </summary>
        /// <returns></returns>
        public GetBrowseDailyDeviations GetBrowseDailyDeviations()
        {
            return new GetBrowseDailyDeviations(_apiBaseUri);
        }

        /// <summary>
        /// Browse what's hot deviations
        /// </summary>
        /// <returns></returns>
        public GetBrowseHot GetBrowseHot()
        {
            return new GetBrowseHot(_apiBaseUri);
        }

        /// <summary>
        /// Fetch MoreLikeThis result for a seed deviation
        /// </summary>
        /// <param name="seedDeviationId"></param>
        /// <returns></returns>
        public GetBrowseMoreLikeThis GetBrowseMoreLikeThis(string seedDeviationId)
        {
            return new GetBrowseMoreLikeThis(_apiBaseUri, seedDeviationId);
        }

        /// <summary>
        /// Fetch More Like This preview result for a seed deviation
        /// </summary>
        /// <param name="seedDeviationId"></param>
        /// <returns></returns>
        public GetBrowseMoreLikeThisPreview GetBrowseMoreLikeThisPreview(string seedDeviationId)
        {
            return new GetBrowseMoreLikeThisPreview(_apiBaseUri, seedDeviationId);
        }

        /// <summary>
        /// Browse newest deviations
        /// </summary>
        /// <returns></returns>
        public GetBrowseNewest GetBrowseNewest()
        {
            return new GetBrowseNewest(_apiBaseUri);
        }

        /// <summary>
        /// Browse popular deviations
        /// </summary>
        /// <returns></returns>
        public GetBrowsePopular GetBrowsePopular()
        {
            return new GetBrowsePopular(_apiBaseUri);
        }

        /// <summary>
        /// Browse a tag
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public GetBrowseTags GetBrowseTags(string tagName)
        {
            return new GetBrowseTags(_apiBaseUri, tagName);
        }

        /// <summary>
        /// Autocomplete tags
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public GetBrowseTagsSearch GetBrowseTagsSearch(string tagName)
        {
            return new GetBrowseTagsSearch(_apiBaseUri, tagName);
        }

        /// <summary>
        /// Browse undiscovered deviations
        /// </summary>
        /// <returns></returns>
        public GetBrowseUndiscovered GetBrowseUndiscovered()
        {
            return new GetBrowseUndiscovered(_apiBaseUri);
        }

        /// <summary>
        /// Browse journals of a user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public GetBrowseUserJournals GetBrowseUserJournals(string username)
        {
            return new GetBrowseUserJournals(_apiBaseUri, username);
        }

        // Collection Endpoints

        /// <summary>
        /// Fetch collection folder contents
        /// </summary>
        /// <param name="folderId"></param>
        /// <returns></returns>
        public GetCollectionFolder GetCollectionFolder(string folderId)
        {
            return new GetCollectionFolder(_apiBaseUri, folderId);
        }

        /// <summary>
        /// Fetch collection folders
        /// </summary>
        /// <returns></returns>
        public GetCollectionFolderList GetCollectionFolderList()
        {
            return new GetCollectionFolderList(_apiBaseUri);
        }

        /// <summary>
        /// Fetch a deviation
        /// </summary>
        /// <param name="deviationId"></param>
        /// <returns></returns>
        public GetDeviation GetDeviation(string deviationId)
        {
            return new GetDeviation(_apiBaseUri, deviationId);
        }

        /// <summary>
        /// Get the original file download (if allowed)
        /// </summary>
        /// <param name="deviationId"></param>
        /// <returns></returns>
        public GetDeviationDownload GetDeviationDownload(string deviationId)
        {
            return new GetDeviationDownload(_apiBaseUri, deviationId);
        }

        /// <summary>
        /// Fetch deviation metadata for a deviation
        /// </summary>
        /// <param name="deviationId"></param>
        /// <returns></returns>
        public GetDeviationMetadata GetDeviationMetadata(string deviationId)
        {
            return new GetDeviationMetadata(_apiBaseUri, deviationId);
        }

        /// <summary>
        /// Fetch deviation metadata for a set of deviations
        /// </summary>
        /// <param name="deviationIds"></param>
        /// <returns></returns>
        public GetDeviationMetadata GetDeviationMetadata(string[] deviationIds)
        {
            return new GetDeviationMetadata(_apiBaseUri, deviationIds);
        }

        /// <summary>
        /// Get the "all" view of a users gallery
        /// </summary>
        /// <returns></returns>
        public GetGalleryAll GetGetGalleryAll()
        {
            return new GetGalleryAll(_apiBaseUri);
        }

        /// <summary>
        /// Fetch gallery folder contents
        /// </summary>
        /// <returns></returns>
        public GetGalleryFolder GetGalleryFolder()
        {
            return new GetGalleryFolder(_apiBaseUri);
        }

        /// <summary>
        /// Fetch gallery folder contents
        /// </summary>
        /// <param name="folderId"></param>
        /// <returns></returns>
        public GetGalleryFolder GetGalleryFolder(string folderId)
        {
            return new GetGalleryFolder(_apiBaseUri, folderId);
        }

        /// <summary>
        /// Fetch gallery folders
        /// </summary>
        /// <returns></returns>
        public GetGalleryFolderList GetGalleryFolderList()
        {
            return new GetGalleryFolderList(_apiBaseUri);
        }

        /// <summary>
        /// Get the user's list of friends
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public GetUserFriendList GetUserFriendList(string username)
        {
            return new GetUserFriendList(_apiBaseUri, username);
        }

        /// <summary>
        /// Get user profile information
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public GetUserProfile GetUserProfile(string username)
        {
            return new GetUserProfile(_apiBaseUri, username);
        }

        /// <summary>
        /// Placebo call to confirm your access_token is valid
        /// </summary>
        /// <returns></returns>
        public GetPlacebo GetPlacebo()
        {
            return new GetPlacebo(_apiBaseUri);
        }
    }
}
