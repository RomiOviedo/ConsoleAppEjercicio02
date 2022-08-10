using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int suma;
            int resta;
            int producto;
            int division;

            Console.Title = "Calculando Numeros Enteros";

            Console.WriteLine("Ingrese el primer numero:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            numero2= int.Parse(Console.ReadLine());

            suma = numero1 + numero2;
            resta = numero1 - numero2;
            producto = numero1 * numero2;
            division = numero1 / numero2;

            Console.WriteLine($"La suma de {numero1} y {numero2} es:{suma}");
            Console.WriteLine($"La resta de {numero1} y {numero2} es:{resta}");
            Console.WriteLine($"La multiplicacion de {numero1} y {numero2} es:{producto}");
            Console.WriteLine($"La division de {numero1} y {numero2} es:{division}");

            Console.ReadLine();

        }
    }
}
