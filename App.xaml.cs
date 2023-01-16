using Hamburger_MateoMolano.Data;
namespace Hamburger_MateoMolano;

public partial class App : Application
{
	public static BurgerDatabase BurgerRepo { get; private set; }
	public App(BurgerDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		BurgerRepo = repo;
	}
}
