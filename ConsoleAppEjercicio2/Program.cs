using System;

namespace ConsoleAppEjercicio2
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

            Console.Write("Ingrese el primer número:");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número:");
            numero2 = int.Parse(Console.ReadLine());

            suma = numero1 + numero2;
            resta = numero1 - numero2;
            producto = numero1 * numero2;
            division = numero1 / numero2;

            Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}");
            Console.WriteLine($"La resta de {numero1} y {numero2} es {resta}");
            Console.WriteLine($"El producto de {numero1} y {numero2} es {producto}");
            Console.WriteLine($"La división de {numero1} y {numero2} es {division}");

            Console.ReadLine();



        }
    }
}
