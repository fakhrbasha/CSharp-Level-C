namespace Tuple_ValueTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, string> t = new Tuple<int, string> (12, "Fakhr") ;
            Console.WriteLine(t.Item1);  // 12
            Console.WriteLine(t.Item2); // Fakhr
            Tuple<int, int, int, double, string> T2 = new Tuple<int, int, int, double, string>(1, 2, 3, 4, "fakhr");
            Console.WriteLine(T2.Item5); // fakhr

            // another way to create tuple 
            var myT=Tuple.Create(10, 23, 5, 99, ".NET");
            Console.WriteLine(myT.Item4); // 99

            // last item name rest

            Console.WriteLine(" -- Value Tuple -- ");
            ValueTuple<int, string, string> emp = (12, "ahmed", "Salah");
            Console.WriteLine(emp.Item1);
            // another def
            (int id, string name, int age) emp2 = (1234, "ahmed", 20);
            Console.WriteLine(emp2.id);
            var x = ( 1 ,  5, "ahmed " , 25 , 8, "ali " , 7 );

            Console.WriteLine(x.Item7);
        }
    }
}
