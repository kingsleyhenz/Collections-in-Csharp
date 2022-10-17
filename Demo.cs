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

            /*foreach (var item in list2)
            {
                Console.WriteLine(item);
            }*/

            ArrayList list3 = new ArrayList() {"Rivers","Benin","Lagos"};
            ArrayList list4 = new ArrayList() {"Imo","Bayelsa"};

          /*  list3.InsertRange(1, list4);*/
                /*list3.RemoveAt(1);
                list3.Remove("Benin");
            foreach (var item in list3)
            {
                Console.WriteLine($"{item}");
            }*/

           /* ArrayList nums = new ArrayList() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            int count = 0;
            for(int i = 0; i < nums.Count; i+=2)
            {
                count += Convert.ToInt32(nums[i]);
            }
            Console.WriteLine(count);
            Console.ReadLine();*/

            Hashtable user = new Hashtable();
            user.Add("046","Sophia");
            user.Add("246", "Ebube");
            user.Add("302", "Nadyne");
            user.Add("169", "Obinna");

            foreach(DictionaryEntry entry in user)
            {
                Console.WriteLine("key: " + entry.Key + " |value: " + entry.Value);
            }
/*REMOVE*/
            if (user.Contains("246"))
            {
                user.Remove("246");
            }

            Console.WriteLine("\n\n");
            foreach (DictionaryEntry entry in user)
            {
                Console.WriteLine("key: " + entry.Key + " |value: " + entry.Value);
            }

            /*UPDATE*/
            if (user.Contains("046"))
            {
                user["046"] = "Okosdo";
            }
            Console.WriteLine("\n\n");
            foreach (DictionaryEntry entry in user)
            {
                Console.WriteLine("key: " + entry.Key + " |value: " + entry.Value);
            }
        }
    }
}
