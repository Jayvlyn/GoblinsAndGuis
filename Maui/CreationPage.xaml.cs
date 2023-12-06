using Maui.ViewModel;

namespace Maui;


public partial class CreationPage : ContentPage
{
	public CreationPage(CreationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}