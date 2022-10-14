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

            foreach(var item in listone)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}
