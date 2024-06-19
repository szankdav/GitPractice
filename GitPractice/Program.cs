namespace GitPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Szia! Kérlek add meg a nevedet: ");
            string nev = Console.ReadLine();
            Console.Write("Kérlek add meg az életkorodat: ");
            int kor;
            while (int.TryParse(Console.ReadLine(), out kor) == false)
            {
                Console.Write("Kérlek csak számot írj be: ");
            }
            Console.WriteLine($"Szia {nev}! Az általad megadott életkor: {kor}");

            Console.ReadKey();
        }
    }
}
