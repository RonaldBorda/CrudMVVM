using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CrudMVVM.Datos;
using CrudMVVM.Helpers;

namespace CrudMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Paginas.PaginaListaEscuelas());
        }

        static BaseDatos bd;

        public static BaseDatos BD
        {
            get
            {
                if (bd == null)
                {
                    bd = new BaseDatos(Constantes.NombreBD);
                }
                return bd;
            }
        }
    }
}