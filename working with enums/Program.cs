using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    class Program
    {
        enum days {sunday,monday,tuesday,wednesday,thursday,friday,saturday}
         public static void Main(string[] args)
        {
            int tuesday = (int) days.tuesday;
            int friday = (int)days.friday;
            Console.WriteLine("tuesday: {0}", tuesday);
            Console.WriteLine("friday: {0}", friday);
            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            string g= new string(letters);
            Console.WriteLine("g: {0}", g);
            Console.ReadKey();
        }
    }
}
