﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace asanchezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        
        public Resumen(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO: " + usuario;
         
        }
    }
}