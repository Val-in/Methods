namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Val";
            Console.WriteLine("\t My name is \n " + MyName);
            byte MyAge = 26;
            Console.WriteLine("\t My age is \n {0}", MyAge);
            
            bool Pet = false;
            Console.WriteLine("Do I have a pet? " + Pet);
            object Size = 37.5;
            Console.WriteLine("My shoe size is {0}", Size);
            Console.WriteLine("\t");

            Console.WriteLine('\u0040');
            Console.WriteLine('\u0023');
            Console.WriteLine("\t");

            Console.ReadKey();
        }
    }
}