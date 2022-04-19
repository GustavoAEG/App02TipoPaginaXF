using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02TipoPaginaXF.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();

          
        }
        private void Ir_Pagina2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pagina2());

        }
        private void Ir_Modal(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Modal());
        }
        private void Chamar_Master(object sender, EventArgs args)
        {

            App.Current.MainPage = new Master.Master();

        }
    }
}