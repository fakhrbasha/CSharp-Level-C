using System.Collections;
namespace Lists_ArrayLists

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* // non genaric collection --> arrayList


             int[] arr = new int[] { 1, 2, 3 }; //  array fixed

             ArrayList arrayList = new ArrayList(); //dynamic object

             arrayList.Add(1); // boxing calue type --> refrance type
             //Console.WriteLine(arrayList[0]); // unboxing object --> value
             arrayList.Add("Hello");
             arrayList.Add(5);
             arrayList.Add(54);
             arrayList.Remove(5); // remove 5
             // arrayList.RemoveAt(1); remove use index
             // 
             arrayList.AddRange(arr); // add arr in arrayList
             arrayList.Insert(2, "Space");

             foreach (var item in arrayList)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine(arrayList.Count); // count
 */

            // generic collection --> List
            int[] arr = new int[] { 1, 5, 6 }; // fixed
            List<int> list = new List<int>();
            list.Add(11);
            list.Add(22);
            //list.Add("str");   error 
            list.AddRange(arr); // 11 22 1 5 6
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(11); //remove 11 
            //list.RemoveAt(1); // remove by index
            list.Insert(1, 77);
            Console.WriteLine(list.Count);

            List<string> l2 = new List<string>();

            List <person> l3 = new List<person>();

            l3.Add(new person()
            {
                id = 1,
                name = "Ahmed"
            });
            l3.Add(new person()
            {
                id = 2,
                name = "Mo"
            });
            l3.Add(new person()
            {
                id = 3,
                name = "Sala"
            });
            foreach (var item in l3)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine(l3[2].id); // 3
            Console.WriteLine("---------");

            List <int> ints = new List<int>() { 1, 30, 44, 12, 3, 7 };
            ints.Sort();
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            bool ex = ints.Contains(30);
            Console.WriteLine(ex); // true or false

           Console.WriteLine( ints.IndexOf(30)); //return index 
            ints.Clear();
            Console.WriteLine(ints.Count);
        }
    }
    public class person
    {
        public int id;
        public string name;
    }
}
