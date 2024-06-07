class Program
{
    static void Main(string[] args)
    {
        // Crear las actividades
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 11, 3), 30, 3.0),
            new Running(new DateTime(2024, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2024, 11, 4), 45, 15.0),
            new Swimming(new DateTime(2024, 11, 5), 60, 20)
        };

        // Mostrar el resumen de cada actividad
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}