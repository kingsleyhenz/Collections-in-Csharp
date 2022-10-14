using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collection
{
    public class Demo
    {
        static void Main(string[] args)
        {

            ArrayList listone = new ArrayList();
            listone.Add(201);
            listone.Add("Sophia");
            listone.Add(" ");
            listone.Add(true);
            listone.Add(4.5);
            listone.Add(null);

           /* foreach (var item in listone)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

            int firstnum = Convert.ToInt32(listone[0]);
            Console.WriteLine(firstnum);
            String Second = Convert.ToString(listone[1]);
            Console.WriteLine(Second);
            double third = Convert.ToDouble(listone[4]);
            Console.WriteLine(third);
           */
            ArrayList list2 = new ArrayList() { 101, "Mike", true, 10.30 };
            /*INSERT INTO ARRAYLIST*/
            list2.Insert(0, "Wutche");
            list2.Insert(3, 509);
            list2.Remove(0);

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
