using Blazor.Shared;

namespace Blazor.Server;

public class PlatformNameProvider : IPlatformNameProvider
{
	public string GetPlatformName() => "ASP.NET Core Blazor Server";
}
