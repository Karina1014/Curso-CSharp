using System.Globalization;

partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(2001, 6, 30); // Fecha de nacimiento
        TimeSpan difference = DateTime.Now - birthDate; // Diferencia entre la fecha actual y la fecha de nacimiento
                                        //Restamos con fecha de nacimiento con la actual
        Console.WriteLine($"Has vivido {difference.TotalDays} días.");                                  

    }
}

// 🏆 Ejercicio:
// Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
// Consideraciones:
// - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
//   asegurando que las comparaciones de fechas no sean afectadas por las horas.
// - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
// - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
//   sumando un año para calcular la fecha del próximo (opcional).


partial class Program
{
    static void DaysUntilNextBirthday()
    {
        Console.WriteLine("Calculador de días hasta el próximo cumpleaños");
        Console.WriteLine("");
        Console.Write("Ingrese su fecha de nacimiento (dd/MM/yyyy):");
        string cumple = Console.ReadLine();
        DateTime birthand = DateTime.ParseExact(cumple, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime today = DateTime.Today;
        DateTime nextBirthday = new DateTime(today.Year, birthand.Month, birthand.Day);
        if (nextBirthday < today)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        TimeSpan difference = nextBirthday - today;
        Console.WriteLine($"Faltan {difference.TotalDays} días para tu próximo cumpleaños.");
    }
}