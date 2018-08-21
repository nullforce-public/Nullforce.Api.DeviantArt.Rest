using FluentAssertions;
using Nullforce.Api.DeviantArt.Rest.UtilityEndpoints;
using System;
using Xunit;

namespace Nullforce.Api.DeviantArt.Rest.Tests
{
    public class GetPlaceboTests
    {
        private const string _baseUri = "http://localhost";

        [Fact]
        public void Constructor_ShouldHaveValidUri()
        {
            var getPlacebo = new GetPlacebo(_baseUri);

            var uri = getPlacebo.Uri;

            uri.Should().Be($"{_baseUri}/placebo");
        }
    }
}
