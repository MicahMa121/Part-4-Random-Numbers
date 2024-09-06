namespace Part_4_Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is a random number generator!(Press \'ENTER\' to start)");
            Console.ReadLine();
            Random random = new Random();
            int min, max,digit;
            do
            {
                Console.WriteLine("Please enter the minimum value!(integer)");
            }
            while (!int.TryParse(Console.ReadLine(), out min));
            do
            {
                Console.WriteLine("Please enter the maximum value!(integer)");
            }
            while (!int.TryParse(Console.ReadLine(), out max)||!(max>=min));
            do
            {
                Console.WriteLine("Please enter how many decimal place you would like!(integer)");
            }
            while (!int.TryParse(Console.ReadLine(), out digit));
            Console.WriteLine(Math.Round(random.Next(min,max)+random.NextDouble(),digit));
        }
    }
}
