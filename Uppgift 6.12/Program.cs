namespace Uppgift_6._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bestäm höjden:");
            int höjd = int.Parse(Console.ReadLine());
            Triangel(höjd);
            Console.ReadKey();
        }

        static void Triangel(int höjd)
        {
            for(int i = 0; i < höjd; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    for (int j = 0; j < i + 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}