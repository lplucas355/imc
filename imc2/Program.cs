using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace imc2 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite seu peso : ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("digite sua altura : ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double imc = peso / (altura * altura);

            if (imc >= 18.5 && imc <= 24.9) {
                Console.WriteLine(" Seu IMC está normal : " + imc.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (imc >= 25.0 && imc <= 29.9) {
                Console.WriteLine(" Seu IMC é Sobrepeso : " + imc.ToString("f2", CultureInfo.InvariantCulture));
            }
            else if (imc >= 30.0 && imc <= 39.0) {
                Console.WriteLine(" Seu IMC é Obesidade : " + imc.ToString("f2", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine(" Seu IMC é Obesidade Grave : " + imc.ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
