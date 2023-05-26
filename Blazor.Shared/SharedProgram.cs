using AntDesign.ProLayout;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Shared
{
	public static class SharedProgram
	{
		public static void RegisterService(IServiceCollection services)
		{

			services.AddAntDesign();
		}
		public static void Configuration(IServiceCollection services)
		{
			services.Configure<ProSettings>(x =>
			{
				x.Title = "Ant Design Pro";
				x.NavTheme = "light";
				x.Layout = "side";
				x.PrimaryColor = "daybreak";
				x.ContentWidth = "Fluid";
				x.HeaderHeight = 64;
				x.FooterRender = false;

			});
		}
	}
}
