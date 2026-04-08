partial class Program
{
    static void AnonymousFunctions()
    {
        Console.WriteLine(square(5));
        Console.WriteLine(lambdaSquare(10));
        //Lista de expreciones 
        List<int> numbers = [1,2,3,4,5];
        var evenNumbers = numbers.Where(n => n % 2 == 0 );
        foreach (var even in evenNumbers)
        {
            Console.WriteLine(even);
        }
    }

    //funcion anonima
    static Func<int, int> square = delegate (int number)
    {
        return number * number;
    };

    //expresion lambda
    static Func<int, int> lambdaSquare = x => x * x;
}


// //
// 🔴 Forma normal (función clásica)
        // int Cuadrado(int x)
        // {
        //     return x * x;
        // }
// 🟢 Forma lambda (lo mismo, pero corto)
//      x => x * x