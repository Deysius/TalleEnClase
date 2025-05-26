using Microsoft.Maui.Controls.Compatibility;

namespace TalleEnClase.Views;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    private void IrAAbsolute_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteLayour());
    }
}