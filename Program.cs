using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Você pecisa calcular a velocidade média?");

            Console.WriteLine(" pressione enter para continuar...:");

            Console.ReadKey();



            Console.WriteLine("Informe a distância em metros (M) percorrida.");

            double espaço = double.Parse(Console.ReadLine());



            Console.WriteLine("Informe o tempo em segundos (S) que foi gasto.");

            double tempo = double.Parse(Console.ReadLine());



            Console.Write("Sua velocidade média é: ");

            double resultado = (espaço / tempo);

            Console.Write( resultado);

            Console.WriteLine(" m/s.");



            Console.ReadKey();
        }
    }
}
