using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDesSis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada
            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            //cálculo do imc(processamento)
            double imc = peso / (altura * altura );
            Console.WriteLine("Seu IMC é de: " + imc);
            if (imc < 16.9)
            {
                Console.WriteLine("Muito abaixo do peso.");

            }
            else if (imc < 18.4)
            {
                Console.WriteLine(" Abaixo do peso.");

            }
            else if (imc < 24.9)
            {
                Console.WriteLine(" Peso normal.");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine(" Acima do peso.");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine(" Obesidade grau I.");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade grau II.");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade grau III");
            }
            Console.ReadKey();
        }
    }
}
