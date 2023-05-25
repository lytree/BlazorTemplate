using Blazor.Shared;

namespace Blazor.Maui;

public class PlatformNameProvider : IPlatformNameProvider
{
	public string GetPlatformName() => "Android";
}
