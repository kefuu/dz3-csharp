namespace dz3_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Website website = new Website();

            website.InputData();

            Console.WriteLine("Дані про сайт:");
            website.OutputData();

        }
    }
}