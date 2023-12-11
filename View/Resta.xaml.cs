namespace Opercaciones.View;

public partial class Resta : ContentPage
{
	public Resta()
	{
		InitializeComponent();
	}

    private void ButtonRestar_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(imputUno.Text, out double valorUno) &&
            double.TryParse(imputDos.Text, out double valorDos))
        {

            double resultado = valorUno - valorDos;
            DisplayAlert("Resultado", $"La Resta es: {resultado}", "Aceptar");
        }
        else if ((imputUno.Text == "." || imputUno.Text == "-") ||
                (imputDos.Text == "." || imputDos.Text == "-"))
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
    }
}