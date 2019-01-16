# Nullforce.Api.DeviantArt.Rest
Builds URLs for the DeviantArt API.

## Authorization
You're responsible for providing an API key and/or appending the appropriate OAuth 1.0a Authorize header to the request.

## Example Usage
```csharp
var client = new RestClient(apiKey);

// Make a request via Flurl.Http
var watching = await client
                    .GetUserFriendList("nullforce")
                    .WithPageLimit(50)
                    .WithPageOffset(offset)
                    .Uri
                    .WithClient(fc)
                    .WithOAuthBearerToken(_token)
                    .GetStringAsync();

var friendList = JsonConvert.DeserializeObject<GetUserFriendListResponse>(watching);
```

## Building
Prerequisites:
* .NET Core SDK

First, install the dotnet tool for Cake (may require restarting a PowerShell console):

```powershell
dotnet tool install -g Cake.Tool
```

From the root of the repository:

```powershell
dotnet cake build.cake
```

## NuGet Package
Coming soon!
