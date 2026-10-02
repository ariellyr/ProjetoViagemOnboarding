using ProjetoViagemOnboarding.VIewModels; 

namespace ProjetoViagemOnboarding.Views;

public partial class ViagemPage : ContentPage
{
	public ViagemPage(ViagemViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}