partial class Program{
    
    //clasd de tipos de valor y refencia
    static void TypeDifference()
    {
        //por mas que le di un valor tendra el valor q tiene 
        int x = 5;
        int y =x;
        y=15;
        Console.WriteLine($"Valor de x: {x}, y:{y}"); // Imprime 5 
        

        Person person1 = new Person { Name = "Alice" };
        Person person2 = person1;
        person2.Name = "Karina";
        Console.WriteLine($"personal1.Name: {person1.Name}");
    }
}

//creamos una clase 
class Person
{
    public string? Name { get; set; }
}