partial class Program 
{ 
    static void SalesReport ()
    {
        string productName = "Laptop";
        int quantitySold = 50;
        decimal pricePerUnit = 10.99m;
        decimal totalRevenue = quantitySold * pricePerUnit;

        Console.WriteLine($"Producto: {productName}");
        Console.WriteLine($"Cantidad Vendida: {quantitySold}");
        Console.WriteLine($"Precio por Unidad: ${pricePerUnit}");
        Console.WriteLine($"Ingresos Totales: ${totalRevenue}");
    }
}

// 🏆 Ejercicio:
// Crear un programa que calcule el salario mensual de un trabajador
// - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
// - Calcular el sueldo y mostrarlo en pantalla

partial class Program 
{
    static void SalesReportTask()
    {
        Console.WriteLine("Calculador de Salario");
        Console.WriteLine("");
        Console.Write("Ingrese su nombre:");
        string? name = Console.ReadLine();
        Console.WriteLine("Ingrese las horas trabajadas:");
        double hour = double.Parse(Console.ReadLine()!); //parse convierte de string a double + 
        // ! un operador "null-forgiving" que se utiliza para indicar que una expresión no es null, incluso si el tipo de la expresión permite valores null.
        Console.WriteLine("Ingrese la Salario por hora:");
        double salary = double.Parse(Console.ReadLine()!);
        double totalSalary = hour * salary;
        Console.WriteLine($"El salario de {name} es: ${totalSalary}");
    }
}