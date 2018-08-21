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
Run the Cake Build script from PowerShell:

```powershell
.\build.ps1
```

## NuGet Package
Coming soon!
