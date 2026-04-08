partial class Program
{   
    //metodo con parametos
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    //metodo con un parametro
    static string EvalueteNumber (int number)
    {
        if (number >0)
            return "Positivo";
        else if (number < 0)
            return "Negativo";
        else
            return "Cero";
    }
    // funcion de parametos 
    static void Functions()
    {
        var area = CalculateArea(4.5 , 2.23);
         Console.WriteLine ($"El área es {area}");
        var evaluedNumber = EvalueteNumber(+45);
         Console.WriteLine($"El número evaluado es: {evaluedNumber}");
    }
}