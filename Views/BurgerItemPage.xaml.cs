using Hamburger_MateoMolano.Data;
using Hamburger_MateoMolano.Models;
namespace Hamburger_MateoMolano.Views;

[QueryProperty("Item", "Item")]
public partial class BurgerItemPage : ContentPage
{
	Burger GB = new Burger();
	bool _flag;
	public BurgerItemPage()
	{
		InitializeComponent();
	}
	public Burger Item
	{
		get => BindingContext as Burger;
		set => BindingContext = value;
	}
	

	private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		_flag = e.Value;
	}
	

	private void OnCancelClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync(nameof(BurgerListPage));

    }

	private void OnSaveClicked(object sender, EventArgs e)
	{
		Item.Name = nameB.Text;
		Item.Description = descB.Text;
		Item.WithExtraCheese = _flag;
		App.BurgerRepo.AddNewBurger(Item);
		Shell.Current.GoToAsync("..");
	}

	private void OnDeleteClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("..");
    }
}