namespace CaraOuCoroaV2.Views;
using CaraOuCoroaV2.ViewModels;
using CaraOuCoroaV2.Models;

public partial class CoinFlip : ContentPage
{
	public CoinFlip()
	{
		InitializeComponent();

		BindingContext = new CoinViewModel();
	}
}