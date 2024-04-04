namespace aplub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string son = Console.ReadLine();

            int a = int.Parse(son.Split()[0]);
            int b = int.Parse(son.Split()[1]);

            Console.WriteLine(a + b);
        }
    }
}
