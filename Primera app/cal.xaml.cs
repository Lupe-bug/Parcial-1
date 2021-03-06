using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Primera_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cal : ContentPage
    {
        public cal()
        {
            InitializeComponent();
            pic.Items.Add("Multiplicación");
            pic.Items.Add("suma");


        }

        private void pic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op = pic.SelectedItem.ToString();
            int n1 = Int32.Parse(num1.Text);
            int n2 = Int32.Parse(num2.Text);
            double res = 0;

            if (op == "Suma") 
            res = n1 + n2;
            else if (op == "Multiplicación") ;
            res = n1 * n2;
            lares.Text = res + "";


        }
    }
}