using FluentAssertions;
using Nullforce.Api.DeviantArt.Rest.GalleryEndpoints;
using System;
using Xunit;

namespace Nullforce.Api.DeviantArt.Rest.Tests.GalleryEndpoints
{
    public class GetGalleryFolderTests
    {
        private const string _baseUri = "http://localhost";
        private const string _folderId = "1111-1111-1111-1111";

        [Fact]
        public void Constructor_ShouldHaveNoFolderId()
        {
            var getGalleryFolder = new GetGalleryFolder(_baseUri);

            var uri = getGalleryFolder.Uri;

            uri.Should().Be($"{_baseUri}/gallery");
        }

        [Fact]
        public void ConstructorWithFolderId_ShouldHaveFolderIdInUri()
        {
            var getGalleryFolder = new GetGalleryFolder(_baseUri, _folderId);

            var uri = getGalleryFolder.Uri;

            uri.Should().Be($"{_baseUri}/gallery/{_folderId}");
        }

        [Fact]
        public void WithUsername_ShouldHaveUsernameParam()
        {
            var getGalleryFolder = new GetGalleryFolder(_baseUri);
            var username = "nullforce";

            var uri = getGalleryFolder
                .WithUsername(username)
                .Uri;

            uri.Should().Be($"{_baseUri}/gallery?username={username}");
        }

        [Fact]
        public void WithSortMode_ShouldHaveModeParam()
        {
            var getGalleryFolder = new GetGalleryFolder(_baseUri);
            var mode = "newest";

            var uri = getGalleryFolder
                .WithSortMode(mode)
                .Uri;

            uri.Should().Be($"{_baseUri}/gallery?mode={mode}");
        }

        [Fact]
        public void WithOffsetAndLimit_ShouldHaveOffsetAndLimitParams()
        {
            var getGalleryFolder = new GetGalleryFolder(_baseUri, _folderId);

            var uri = getGalleryFolder
                .WithPageOffset(1)
                .WithPageLimit(20)
                .Uri;

            uri.Should().Be($"{_baseUri}/gallery/{_folderId}?offset=1&limit=20");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(50_001)]
        public void WithInvalidOffset_ShouldThrow(int offset)
        {
            var getGalleryFolder = new GetGalleryFolder(_baseUri, _folderId);

            Action action = () => getGalleryFolder
                .WithPageOffset(offset);

            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(25)]
        public void WithInvalidLimit_ShouldThrow(int limit)
        {
            var getGalleryFolder = new GetGalleryFolder(_baseUri, _folderId);

            Action action = () => getGalleryFolder
                .WithPageLimit(limit);

            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void WithMatureContent_ShouldHaveAllowMatureParam()
        {
            var getGalleryFolder = new GetGalleryFolder(_baseUri, _folderId);

            var uri = getGalleryFolder
                .WithMatureContent()
                .Uri;

            uri.Should().Be($"{_baseUri}/gallery/{_folderId}?mature_content=true");
        }
    }
}
