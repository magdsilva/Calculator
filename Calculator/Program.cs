using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro Número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Número: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 + n2;
            Console.WriteLine();
            Console.WriteLine($"A soma dos número é: {resultado}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Primeiro Número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Número: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 - n2;
            Console.WriteLine();
            Console.WriteLine($"A subtração dos número é: {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.Write("Primeiro Número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Número: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 / n2;
            Console.WriteLine();
            Console.WriteLine($"A divisão dos número é: {resultado}");
            Console.ReadKey();
        }

        static void Multiplicao()
        {
            Console.Clear();
            Console.Write("Primeiro Número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Número: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 * n2;
            Console.WriteLine();
            Console.WriteLine($"A multiplicação dos número é: {resultado}");
            Console.ReadKey();
        }

        static void Potencia()
        {
            Console.Clear();
            Console.Write("Digite a base: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Diite o expoente: ");
            double n2 = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(n1,n2);
            Console.WriteLine();
            Console.WriteLine($"A potencia entre os número é: {resultado}");
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Claculadora");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potencia");
            Console.WriteLine("6 - Sair");
            Console.WriteLine();
            Console.WriteLine("Digite a operação que deseja realizar!");
            short opcao = short.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicao(); break;
                case 5: Potencia(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
    }
   
}
