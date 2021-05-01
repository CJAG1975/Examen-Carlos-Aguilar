using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AguilarCarlos_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnSiguiente_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("estudiante2021") && txtPassword.Text.Equals("uisrael2021"))
            {
                await Navigation.PushAsync(new Registro(txtUsuario.Text));
            }
            else
            {
                await DisplayAlert("ERROR", "USUARIO INCORRECTO", "ACEPTAR");
            }
        }
    }
}