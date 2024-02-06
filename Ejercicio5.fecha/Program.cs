namespace Ejercicio5.fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba la primera fecha con este formato dd-MM-yyyy: ");

            if (DateTime.TryParse(Console.ReadLine(), out DateTime rimaeraFecha))
            {
                Console.WriteLine("Escriba la segunda fecha con este formato dd-MM-yyyy: ");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime fecha2))
                {
                    TimeSpan resta = fecha2 - rimaeraFecha;

                    Console.WriteLine("Faltan: " + resta.TotalDays + "días, " + resta.TotalHours + "horas, " + resta.TotalMinutes + "minutos, " + resta.TotalSeconds + "segundos.");
                } 
            }
        }
    }
}
