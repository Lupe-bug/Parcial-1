using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Primera_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Inicializar();

        }

        private void Inicializar()
        {
            pro1.Clicked += Pro1_Clicked;
            pro2.Clicked += Pro2_Clicked;

        }

        private void Pro2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new pro2());
        }

        private void Pro1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new pro1());
        }
    }
}
