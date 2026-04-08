partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Chevrolet";
        car.Year = 2026;
        Console.WriteLine(car.ShowInfo());
        car.ShowMessages("Cambiando de modelo");
        car.ChangeModel("Mustan");
        Console.WriteLine(car.ShowInfo());


        Car.GeneralInfo();
    }
}


//Creo la clase con sus propiedades 
class Car
{
    //pueda tener valores nulos '?'
    public string? Model {get; set;}
    public int? Year {get; set;}

    public void ChangeModel (string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Automovil {Model}, año {Year}";
    }

    public void ShowMessages() => Console.WriteLine("Este es un automovil");

    public void ShowMessages(string message) => Console.WriteLine(message);

    public static void GeneralInfo()
    {
        Console.WriteLine("El autómovil es uno de los transportes más utilzzados");
    }


}