using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main()
        {
            Round round = null;
            string file = "in.txt"/*Console.ReadLine()*/;
            try
            {
                round = FileReading.Reading(file);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (round != null)
            {
                round.Area();
                round.Lenght();
                round.Show();
            }

            Console.ReadKey();
        }
    }
}