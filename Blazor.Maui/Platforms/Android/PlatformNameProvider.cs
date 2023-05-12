using Blazor.Shared;

namespace Blazor.Maui.Platforms.Android;

public class PlatformNameProvider : IPlatformNameProvider
{
	public string GetPlatformName() => "Android";
}
