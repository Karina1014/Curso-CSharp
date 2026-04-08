partial class Program
{
    static void TestingClass()
    {
        //creamos una instancia:
        Vehicle  toyota = new Vehicle();
        toyota.Brand = "TOYOTA";
        toyota.Model = "Civic";
        toyota.Year = 2021;
        toyota.ShowInfo();

        //Creamos otro vehiculo
        //Se puede instalar directamente
        Vehicle honda = new Vehicle{Brand="Honda", Model="Civic", Year=2025};
        honda.ShowInfo();

        Vehicle renault = new Vehicle ("Renault","Duster",2024);
        renault.ShowInfo();
    }
}

//Definir una clase
class Vehicle
{
    //Clase tiene sus propiedades 
    public string? Brand {get;set;}
    public string? Model {get;set;}
    public int Year {get;set;}

    //Creamos el constructor siempre con el mismo nombre de la clase <<===
    //Como creamos el construtor esta esperando q le pasemos esos tres parametros para 
    //poder inicializar
    public Vehicle (string brand, string model , int year)
    {
        Brand = brand;
        Model = model;
        Year = year;

    }
    // para que no se rompa nuestro constructor (){} no se rompa nada
    public Vehicle(){}

    //Clase tiene sus metodos
    // Mostrar las caracteristicas del Vehicle
    public void ShowInfo()
    {
        Console.WriteLine($"Este Vehiculo es un {Brand} {Model} del año {Year}");

    }
}