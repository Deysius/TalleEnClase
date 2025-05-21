using TalleEnClase.Views;

namespace TalleEnClase
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void IrAStack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());

        }
    }

}
