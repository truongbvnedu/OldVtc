using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        Hashtable week = new Hashtable();
        week.Add(1, "Monday");
        week.Add(2, "Tuesday");
        week.Add(3, "Wendnesday");
        week.Add(4, "Thursday");
        week.Add(5, "Friday");
        week.Add(6, "Saturday");
        week.Add(7, "Sunday");
        week.Add(8, "no day more");
        if (week.ContainsValue("Tuesday"))
        {
            Console.WriteLine("Tuesday co trong Hashtable");
        }
        else { Console.WriteLine("Tuesday khong co trong Hashtable"); }
        foreach (var key in week.Keys)
        {
            Console.WriteLine(key + " : " + week[key]);
        }
    }
}