namespace Opercaciones.View;

public partial class Suma : ContentPage
{
	public Suma()
	{
		InitializeComponent();
	}

    private void ButtonLimpiar_Clicked(object sender, EventArgs e)
    {
        imputUno.Text = string.Empty;
        imputDos.Text = string.Empty;
        imputTres.Text = string.Empty;

    }

    private void ButtonSumar_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(imputUno.Text, out double valorUno)&&
            double.TryParse(imputDos.Text, out double valorDos)&&
            double.TryParse(imputTres.Text, out double valorTres)){

            double resultado = valorUno + valorDos + valorTres;
            DisplayAlert("Resultado",$"La Suma es:{resultado}","Aceptar");
        }
        else{
            DisplayAlert("Error", "Completa los campos", "OK");
        }
    }
 }
