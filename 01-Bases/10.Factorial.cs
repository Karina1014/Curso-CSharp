partial class Program
{
    // 🏆 Ejercicio:
    // Crear un método llamado `PrintFactorialTable` que reciba un número 
    // y muestre el factorial de todos los números desde 1 hasta el número ingresado.
    // Ejemplo: PrintFactorialTable(5);
    // 1! = 1
    // 2! = 2
    // 3! = 6
    // 4! = 24
    // 5! = 120
    static void PrintFactorialTable(int number)
    {
        Console.WriteLine($"Factorial del {number}");
        Console.WriteLine();

        int resultado = 1; // 🔑 inicializar

        for (int i = 1; i <= number; i++)
        {
            resultado = resultado * i; // 🔑 acumulativo

            Console.WriteLine($"{i}! = {resultado}");
        }

        Console.WriteLine();
    }
}