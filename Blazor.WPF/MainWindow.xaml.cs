using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Blazor.Shared;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blazor.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			var serviceCollection = new ServiceCollection();
			serviceCollection.AddWpfBlazorWebView();
			serviceCollection.AddBlazorWebViewDeveloperTools();
			serviceCollection.AddAutofac();


			var services = new AutofacServiceProvider(RegisterService(serviceCollection));
			Resources.Add("services", services);
			InitializeComponent();
		}

		private static IContainer RegisterService(ServiceCollection services)
		{
			var container = new ContainerBuilder();

			container.RegisterType<PlatformNameProvider>().As<IPlatformNameProvider>();
			container.Populate(services);

			return container.Build();

		}
	}
}
