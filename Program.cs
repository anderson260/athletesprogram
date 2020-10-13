using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace athletes
{
    class Program
    {
        static void Main(string[] args)
        {

            string gender;
            int lanes;
            List<string> athletes = new List<string>(); 

            Console.Write("Enter gender: ");
            gender = Console.ReadLine();

            if (gender != "male" || gender != "female")
            {
                Console.WriteLine("Invalid enter male or female");
                return;
            }

            Console.Write("Enter number of lanes: ");
            lanes = int.Parse(Console.ReadLine());

            if (lanes < 4 || lanes > 8 )
            {
                Console.WriteLine("Error number of lanes must be between 4 and 8");
            }

            for (int i = 0; i < lanes; i++)
            {
                string athlete = Console.ReadLine();
                athletes.Add(athlete);
            }


        }
    }
}
