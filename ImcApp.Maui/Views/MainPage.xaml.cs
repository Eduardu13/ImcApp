using ImcApp.Maui.Models;

namespace ImcApp.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new ImcApp.Maui.MainViewModel.MainViewModel();
	
    }

}