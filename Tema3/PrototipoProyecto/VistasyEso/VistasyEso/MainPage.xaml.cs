using System.Threading.Tasks;
using VistasyEso.View;
namespace VistasyEso
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            ///Aqui deberíamos controlar si el usuario está bien puesto o no.
            ///En el caso de que si pues iniciamos ventana de usuario
            ///En el caso de que no, decimos nono, tu no
            ///Controlar mediante tokens, como cojones voy a hacer eso??
            ///y luego registrarse pues eso, a registrarse.
            
             await DisplayAlert("todavia no esta","losiento","miau");
        }

        private async void registerBtn_Clicked(object sender, EventArgs e)
        {
            RegisterPage rg = new RegisterPage();
            await Navigation.PushAsync(rg);
        }
    }
}
