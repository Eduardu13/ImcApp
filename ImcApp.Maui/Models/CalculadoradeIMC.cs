using System;
using System.Collections.Generic;
using System.Text;


namespace ImcApp.Maui.Models
{
    public static class CalculadoradeIMC
    {
        public static decimal IndiceDeMasaCorporal (decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }

        public static string SituacionNutricional (decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso Bajo";
            }
            if (imc < 25.0m)
            {
                return "Peso Normal";
            }
            if (imc < 30.0m)
            {
                return "Sobre Peso";
            }
            if (imc < 40.0m)
            {
                return "Obesidad";
            }
                return "Obesidad Extrema";
            
        }
    }
}
