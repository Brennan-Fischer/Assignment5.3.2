namespace Assignment5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will infrom you the number of different ways you can traverse a set of stairs assuming you can either climb 1 or 2 stairs at a time");
            Console.WriteLine("Input number of stairs to travers");
            int stairs =Convert.ToInt32(Console.ReadLine());
            int[] combinations = new int[stairs+1];
            combinations[0] = 0;
            combinations[1] = 1;
            combinations[2] = 2;
            if (stairs > 2)
            {
                for (int i = 3; i <= stairs; i++)
                {
                    combinations[i] = combinations[i - 1] + combinations[i - 2];
                }
              
            }
            Console.WriteLine($"Number of combinations to climb {stairs}s is {combinations[stairs]}");
        }
    }
}
