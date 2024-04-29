namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Val";

            Console.WriteLine(MyName);
            Console.WriteLine("\t Hello World");
            Console.WriteLine("\t Мне 26 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);

            Console.WriteLine('\u0040');
            Console.WriteLine('\u0023');
            Console.ReadKey();
        }
    }
}
