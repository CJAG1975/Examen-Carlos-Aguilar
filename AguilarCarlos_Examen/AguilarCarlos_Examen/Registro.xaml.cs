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
    public partial class Registro : ContentPage
    {
        string nombreUsuarioDb = "";
        double pagoTotal = 0;
        public Registro(string nombreUsuarioDb)
        {
            InitializeComponent();
            this.nombreUsuarioDb = nombreUsuarioDb;
            lblNombreUsuario.Text = "Usuario db: " + nombreUsuarioDb;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double valorEstablecido = 1800;
            double saldoInicial     = Double.Parse(txtSaldoInicial.Text);

            double costoSinPagoInicial = valorEstablecido - saldoInicial;
            double porcentaje          = valorEstablecido * 0.05;
            double cuotas              = costoSinPagoInicial / 3;
            double mensual             = (porcentaje) + (cuotas);

            this.pagoTotal             = mensual * 3;
            txtPagoMensual.Text        = "Pago mensual: " + mensual.ToString();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            await DisplayAlert("INFO", "ELEMENTO GUARDADO CORRECTAMENTE", "OK");
            await Navigation.PushAsync(new Resumen(nombre, this.pagoTotal, this.nombreUsuarioDb));
        }
    }
}