using Hamburger_MateoMolano.Data;
using Hamburger_MateoMolano.Models;
namespace Hamburger_MateoMolano.Views;

public partial class BurgerListPage : ContentPage
{
	public BurgerListPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
	private void OnItemAdded(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
		{
			["Item"] = new Burger()
		});
	}
	private void ActualizarBurger(object sender, EventArgs e)
	{
		List<Burger> burger = App.BurgerRepo.GetAllBurgers();
		burgerList.ItemsSource = burger;
	}
	
}