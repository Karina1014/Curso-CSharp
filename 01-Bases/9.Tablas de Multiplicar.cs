partial class Program
{
    //Metodo con paramteros
    static void PrintMultuplicationTable (int number, int tableLimit)
    {
        Console.WriteLine($"Tabla de multiplicar del numero {number} desde el 1 hasta el {tableLimit}");
        Console.WriteLine($"");
        for (int i = 0; i < tableLimit; i++)
        {
            Console.WriteLine($"{number} x {number * i}");
        }
        Console.WriteLine($"");
    }

}