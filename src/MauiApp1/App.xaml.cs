using System.Reflection;

namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
		=> new MainWindow(new AppShell());

	public static string MauiVersion
	{
		get
		{
			var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
			return $".NET MAUI ver. {version[..version.IndexOf('+')]}";
		}
	}
}
