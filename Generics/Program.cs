namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product<string, int> p = new product<string, int>()
            {
                Name = "Fakhor",
                Price = 200
            };
            p.print();

            product<string, double> p2 = new product<string, double>()
            {
                Name = "Fakhor",
                Price = 200.8
            };
            p2.print();
            product<int, double> p3 = new product<int, double>()
            {
                Name = 142554,
                Price = 2.88
            };
            p3.print();
            // p3.printProductName(); // int becouse T in p3 int
            // p2.printProductName() // string becouse T in p2 string
            p3.printProductName(12, "Generics");

           printer pr = new printer();
            pr.print(7);
            pr.print<string>("Gen");
        }
    }
    public class product<T, U> // Generic Class
    {
        public T Name { get; set; }
        public U Price { get; set; }

        public T[] GenArr = new T[5]; // Generic Array
        public void print()
        {
            Console.WriteLine($"Name {Name} - Price {Price}");
        }
        public void printProductName(T name , string G) // Generic Method
        {
            Console.WriteLine(name);
            Console.WriteLine(G);
        }
    }
    public class printer // generic method in non generic class
    {
        public void print<T>(T val)
        {
            Console.WriteLine(val);
        }
    }
}
