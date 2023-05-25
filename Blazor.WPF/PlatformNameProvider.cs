using Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.WPF
{
	public class PlatformNameProvider : IPlatformNameProvider
	{
		public string GetPlatformName()
		{
			return "ASP.NET Core Blazor WPF";
		}
	}
}
