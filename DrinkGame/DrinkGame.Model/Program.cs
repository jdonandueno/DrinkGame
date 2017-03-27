using System;

namespace DrinkGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esto es un juego de beber");
            Console.WriteLine("Las condiciones son faciles: Van a iterarse numeros del 1 al 100, ");
            Console.WriteLine("y por cada vez que se encuentre un multiplo de 3, debe " +
                              "reemplazarse por \"fizz\".");
            Console.WriteLine("Los multiplos de 7, en cambio, deben reemplazarse por \"buzz\".");
            Console.WriteLine("Si hay un numero multiplo de ambos, debe imprimirse la palabra " +
                              "\"fizzbuzz\"");
            Console.WriteLine("Presiona enter para comenzar");
            Console.ReadLine();
            Game game = new FizzBuzz(3, 7);
            Console.Write(game.Play(100));
        }
    }
}
