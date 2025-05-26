namespace TalleEnClase.Views;

public partial class AbsoluteLayour : ContentPage
{
	public AbsoluteLayour()
	{
		InitializeComponent();
	}

    private void IrAGrid_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());

    }
}