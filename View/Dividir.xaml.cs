namespace Opercaciones.View;

public partial class Dividir : ContentPage
{
	public Dividir()
	{
		InitializeComponent();
	}

    private void ButtonDividir_Clicked(object sender, EventArgs e)
    {
            if (double.TryParse(imputDividendo.Text, out double valorUno) &&
                  double.TryParse(imputDivisor.Text, out double valorDos))
            {

            if (valorDos == 0)
            {
                DisplayAlert("Ups", "No se puede dividir entre 0", "Aceptar");

            }
            else
            {
                double resultado = valorUno / valorDos;
                DisplayAlert("Resultado", $"La Divicion es: {resultado}", "Aceptar");
            }
                
            }
            else if ((imputDividendo.Text == "." || imputDividendo.Text == "-") ||
                    (imputDivisor.Text == "." || imputDivisor.Text == "-"))
            {
                DisplayAlert("Error", "Completa los campos con numeros", "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Completa los campos", "Aceptar");
            }
              
    }

    private void ButtonLimpiar_Clicked(object sender, EventArgs e)
    {
        imputDividendo.Text = string.Empty;
        imputDivisor.Text = string.Empty;
    }
}