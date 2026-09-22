using ImcApp.Maui.Models;

namespace ImcApp.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        LimpiarValores();
	}

    private void OnButtonClicked(object sender, EventArgs e)
    {
        decimal peso;
        bool PesoValido = decimal.TryParse(PesoLabel.Text, out peso);

        decimal estatura;
        bool estaturaValida = decimal.TryParse(EstaturaLabel.Text, out estatura);

       if (PesoValido && estaturaValida)
        {
            decimal imc = CalculadoradeIMC.IndiceDeMasaCorporal(peso, estatura);

            ImcLabel.Text = imc.ToString("F4");

            PesoNutriLabel.Text = CalculadoradeIMC.SituacionNutricional(imc);
        }
    }
    private void OnLimpiarButtonClicked(object sender, EventArgs e)
    {
        LimpiarValores();
    }

    private void LimpiarValores()
    {
        PesoLabel.Text = string.Empty;
        EstaturaLabel.Text = string.Empty;
        ImcLabel.Text = string.Empty;
        PesoNutriLabel.Text = string.Empty;
    }
}