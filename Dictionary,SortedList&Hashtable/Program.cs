using System.Collections;
namespace Dictionary_SortedList_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary  key , value
            Dictionary <string , int> ages = new Dictionary <string , int> ();
            ages.Add("Ahmed", 20);
            ages.Add("fakhr", 22);
            ages.Add("Mo", 30);
            // ages.Add("Ahmed", 20); ; // error must key is uniqee but value not must
            var res = ages["Mo"];
           // Console.WriteLine (res); // 30
            foreach (var item in ages) { 
                Console.WriteLine ($"Item key : {item.Key}  item value : {item.Value}");
            }
            Console.WriteLine(" --- Sorted List ---");
            // dictionary sorted
            SortedList<int , string> employee = new SortedList<int, string> ();
            employee.Add(142, "Ahmed");
            employee.Add(98, "ali");
            employee.Add(454, "fakhr");
            foreach (var item in employee) {
                Console.WriteLine($"Item key : {item.Key} item value : {item.Value}"  );
            }
            Console.WriteLine(" -- Hashtable -- ");

            // Dictionary - SortedList  Generic
            // hashtable non generic
            Hashtable emp = new Hashtable ();
            emp.Add(10, "ENG");
            emp.Add(20, "Dr");
            var ress = (string)emp[10]; // return object must use type casting 
            Console.WriteLine (ress);


        }
    }
}
