using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImcApp.Maui.Models;

namespace ImcApp.Maui.MainViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]

        private string _estatura;

        [ObservableProperty]

        private string _peso;

        [ObservableProperty]

        private string _imc;

        [ObservableProperty]

        private string _situacionNutricional;

        public MainViewModel()
        {
            Limpiar();
            
        }

        [RelayCommand]

        private void Limpiar()
        {
            Peso = string.Empty;
            Estatura = string.Empty;
            Imc = string.Empty;
            SituacionNutricional = string.Empty;
        }

        [RelayCommand]

        public void Calcular()
        {
            decimal peso;
            bool PesoValido = decimal.TryParse(Peso, out peso);

            decimal estatura;
            bool estaturaValida = decimal.TryParse(Estatura, out estatura);

            if (PesoValido && estaturaValida)
            {
                decimal imc = CalculadoradeIMC.IndiceDeMasaCorporal(peso, estatura);

                Imc = imc.ToString("F4");

                SituacionNutricional = CalculadoradeIMC.SituacionNutricional(imc);
            }
        }

    }
}
