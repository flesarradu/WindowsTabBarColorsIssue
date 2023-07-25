using WindowsTabBarColorsIssue.Pages;

namespace WindowsTabBarColorsIssue;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("ContactViewModel", typeof(ContactTabPage));
		Routing.RegisterRoute("HomeViewModel", typeof(HomeTabPage));
		Routing.RegisterRoute("ProductsViewModel", typeof(ProductsTabPage));
		
	}
}
