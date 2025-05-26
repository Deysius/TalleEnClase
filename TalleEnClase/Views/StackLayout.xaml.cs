namespace TalleEnClase.Views;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

    private void IrAFlexPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexLayout());

    }
}
