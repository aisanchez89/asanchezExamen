using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace asanchezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuario1;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO: "+ usuario;
            usuario1 = usuario;
        }

        private void txtmontoin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtpagomensual_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPmensual_Clicked(object sender, EventArgs e)
        {

        }

        private void txtResumen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen(usuario1());
        }
    }
}