partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (42,"hola");
        Console.WriteLine($"Número: {myTuple.Item1}, texto {myTuple.Item2}");

        (int number, string Text) myOtherTuple = (33,"Kari");
        Console.WriteLine($"Número: {myOtherTuple.Item1}, texto {myOtherTuple.Item2}");


    }
}