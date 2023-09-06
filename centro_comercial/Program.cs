using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centro_comercial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad, adivinanzas_acertadas;
            double  extra_edad,monto_adivina,monto_inicial,monto_Final;
            Console.WriteLine("Ingrese su edad:");
            edad=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de adivinanzas:");
            adivinanzas_acertadas = int.Parse(Console.ReadLine());
            extra_edad = 5*edad;
            monto_adivina = 2*adivinanzas_acertadas;
            monto_inicial = 0;
            if (edad >= 18)
            {
                if (adivinanzas_acertadas >= 3)
                {
                    monto_inicial = 50;
                }
                else
                {
                    monto_inicial = 30;
                }
            }
            else
            {
                if (adivinanzas_acertadas >= 3)
                {
                    monto_inicial = 80;
                }
                else
                {
                    monto_inicial=50;
                }
            }
            monto_Final=monto_inicial+extra_edad+monto_adivina;
            Console.WriteLine("El monto final que el ganador recibe como premio es: S/."+ monto_Final);
            Console.ReadKey();
        }
    }
}
