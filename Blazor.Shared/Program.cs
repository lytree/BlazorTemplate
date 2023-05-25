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
	public static class Program
	{
		public static void RegisterService(ServiceCollection services)
		{


		}
		public static void Configuration(ServiceCollection services)
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
