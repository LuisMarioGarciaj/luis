using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,n2,suma;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            suma = n + n2;
            Console.WriteLine("LA SUMA ES " + suma);
        }
    }
}