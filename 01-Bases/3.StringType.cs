partial class Program 
{ 
    static void StringType ()
    {
        string name = "Kari";
        string message = "Hello, World Karilu!";
        string interpolatedMessage = $"Welcome, {name}! {message}";
    

        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);
        Console.WriteLine($"Tu nombre tiene:{name.Length} palabras");           //Version longitud
        Console.WriteLine($"Tu nombre en mayúsculas es: {name.ToUpper()}");     //Version mayusculas
        int number = 24;
        Console.WriteLine(number);
        bool isString = true;
        Console.WriteLine($"¿Es una cadena de texto? {isString}");
    }
}