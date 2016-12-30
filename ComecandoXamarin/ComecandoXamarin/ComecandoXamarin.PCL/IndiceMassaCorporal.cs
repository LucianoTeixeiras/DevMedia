using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComecandoXamarin.PCL
{
    public class IndiceMassaCorporal
    {
        public static decimal Calcular(decimal peso, decimal altura)
        {
            return peso / (altura * altura);
        }
    }
}
