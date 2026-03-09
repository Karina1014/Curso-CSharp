partial class Program
{
    static void ShowTimes()
    {
        //Fecha y hora actual
        DateTime now = DateTime.Now;
        //Solo fecha
        DateTime today = DateTime.Today;
        //Fecha de una semana anterior
        DateTime nowWeekDays = now.AddDays(-7);
        //Fecha especifica seria 2 de marzo de 2026
        DateTime custumDate = new DateTime(2026, 3, 2);
        //Descripcón de una dia de la semana
        DayOfWeek dayOfWeek = now.DayOfWeek;

        Console.WriteLine("***** Formatos de Fechas ***************");
        Console.WriteLine($"Fecha y hora actual: {now}");
        Console.WriteLine($"Solo fecha: {today}");  
        Console.WriteLine($"Fecha de una semana anterior: {nowWeekDays}");
        Console.WriteLine($"Fecha especifica: {custumDate}");
        Console.WriteLine($"Día de la semana: {dayOfWeek}");
    }
}