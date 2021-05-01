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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombreUsuario, double pagoTotal, string nombreUsuarioDb)
        {
            InitializeComponent();
            txtNombreUsuario.Text = "Nombre: " + nombreUsuario;
            txtPagoTotal.Text = "Total a pagar" + pagoTotal.ToString();
            txtNombreUsuarioDb.Text = "Usuario db: " + nombreUsuarioDb;
        }
    }
}