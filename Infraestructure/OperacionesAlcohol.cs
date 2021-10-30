using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resolucion_Ejercicios.Api.Infraestructure
{
    public class OperacionesAlcohol
    {
        public double PruebaAlcoholemia (String EjemplarBebida, Double CantidadConsumida, Double kilos)
        {
            double AlcoholBebido;
            double AlcoholEnSangre;
            double MasaGradoSangre;
            double LitrosSangre;
            double VolumenDeAlcoholEnSangre;

            double miliLitros;
            double NivelDeAlcohol;

            switch (EjemplarBebida)
            {
                case "Cerveza":
                    miliLitros = 330 * CantidadConsumida;
                    NivelDeAlcohol = 5;
                    break;
                case "Vino":
                    miliLitros = 100 * CantidadConsumida;
                    NivelDeAlcohol = 12;
                    break;
                case "Cava":
                    miliLitros = 100 * CantidadConsumida;
                    NivelDeAlcohol = 12;
                    break;
                case "Vermu":
                    miliLitros = 70 * CantidadConsumida;
                    NivelDeAlcohol = 17;
                    break;
                case "Licor":
                    miliLitros = 45 * CantidadConsumida;
                    NivelDeAlcohol = 23;
                    break;
                case "Brandy":
                    miliLitros = 45 * CantidadConsumida;
                    NivelDeAlcohol = 38;
                    break;
                case "Combinado":
                    miliLitros = 45 * CantidadConsumida;
                    NivelDeAlcohol = 38;
                    break;
                default:
                    miliLitros = 0;
                    NivelDeAlcohol = 0;
                    break;     
            }
            
            AlcoholBebido = (NivelDeAlcohol * 0.010) * miliLitros; //Esta formula sirve para calcular el total de alcohol que se ha bebido
            AlcoholEnSangre = 0.15 * AlcoholBebido; //Fórmula para calcular la cantidad de alcohol que va directo a la sangre
            MasaGradoSangre = 0.789 * AlcoholEnSangre; //Fórmula que calcula la masa del etanol en la sangre
            LitrosSangre = 0.08 * kilos; //Fórmula para calcular el volumen de la sangre de la persona tomando en cuenta su peso en kilogramos
            VolumenDeAlcoholEnSangre = MasaGradoSangre / LitrosSangre; //Fórmula para que calculemos el volumen de alcohol en la sangre, dicho de otro modo Alcoholemia
            return VolumenDeAlcoholEnSangre;   
        }
    }
}