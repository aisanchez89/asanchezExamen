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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";

            if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
            {
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Contraseña Incorrecta", "Cancelar");
            }
        }
    }
}