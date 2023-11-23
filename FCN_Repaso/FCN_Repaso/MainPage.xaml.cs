using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FCN_Repaso
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Clicked_Buttom(object sender, EventArgs e)
        {
            if (Latidos.Text == null || Latidos.Text == "")
            {
                DisplayAlert("Error" ,"Introduzca un número", "Ok");
            }
            else
            {
                int latidos = int.Parse(Latidos.Text);
                int fcn = latidos * 4;
                string resultado = "";
                if (fcn < 0)
                {
                   resultado = "Error";
                }

                else if (fcn < 60)
                {
                    resultado = "Es Bajo";
                    imgcomprobar.IsVisible = true;
                    imgcrisis.IsVisible = false;
                }
                else if (fcn >= 60 && fcn <= 100)
                {
                    resultado = "Es Normal";
                    imgcomprobar.IsVisible = true;
                    imgcrisis.IsVisible = false;
                }
                else
                {
                    resultado = "Es Alta";
                    imgcomprobar.IsVisible = false;
                    imgcrisis.IsVisible = true;
                }
                DisplayAlert("Resultado", resultado,"Ok");
            }
        }
    }
}
