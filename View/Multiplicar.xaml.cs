using System.Text.RegularExpressions;

namespace Opercaciones.View;

public partial class Multiplicar : ContentPage
{
	public Multiplicar()
	{
		InitializeComponent();

    }

    private void ButtonMultiplicar_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(imputUno.Text, out double valorUno) &&
                   double.TryParse(imputDos.Text, out double valorDos) &&
                   double.TryParse(imputTres.Text, out double valorTres))
        {
            double resultado = valorUno * valorDos * valorTres;
            DisplayAlert("Resultado", $"La Multipiacion es:{resultado}", "Aceptar");
        }
        else if(imputUno.Text == "." || imputDos.Text == "." || imputTres.Text == ".")
        {
            DisplayAlert("Error", "Completa los campos con numeros", "OK");
        }
        else
        {
            DisplayAlert("Error", "Completa los campos", "OK");
        }
    }

    private void ButtonLimpiar_Clicked(object sender, EventArgs e)
    {
        imputUno.Text = string.Empty;
        imputDos.Text = string.Empty;
        imputTres.Text = string.Empty;
    }
}