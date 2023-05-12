using Blazor.Shared;

namespace Blazor.Wasm;

public class PlatformNameProvider : IPlatformNameProvider
{
	public string GetPlatformName()
	{
		return "ASP.NET Core Blazor WebAssembly";
	}
}
