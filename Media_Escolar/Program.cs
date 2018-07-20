using System;
using System.Globalization;

namespace Media_Escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media , calculo;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            calculo = nota1 + nota2 + nota3 / 3;

            media = calculo;

            if(media <= 55.00) {

                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }

            Console.ReadLine();
        }
    }
}
