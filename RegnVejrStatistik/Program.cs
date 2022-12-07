namespace RegnVejrStatistik;

class Program
{
    public static void Main()
    {
        List<double> list = new List<double>();
        Console.Write("Indtast antallet af måleværdier: ");
        int antalmåleværdier = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        for (int i = 0; i < antalmåleværdier; i++)
        {
            Console.Write($"Indtast måleværdi {i + 1}: ");
            list.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Clear();
           
        }
        Console.Clear();

        Console.WriteLine($"Dit gennemsnit er: {list.Average()}"); 
        Console.WriteLine($"Dit max er: {list.Max()}");
        Console.WriteLine($"Dit min er: {list.Min()}");

    }
}