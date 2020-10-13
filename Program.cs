using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_programming_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = " ";
            int lanes = 0;
            

            while (gender != "male" && gender != "female")
            {
                Console.Write("Enter gender: ");
                gender = Console.ReadLine();
                if (gender != "male" && gender != "female")
                {   
                    Console.WriteLine("Invalid enter male or female\n");
                }                                                                             
            }

            while (lanes < 4 || lanes > 8)
            {
                Console.Write("Enter number of lanes: ");
                lanes = int.Parse(Console.ReadLine());
                if (lanes < 4 || lanes > 8)
                {
                    Console.WriteLine("Error number of lanes must be between 4 and 8\n");
                }              
            }

            double[] times = new double[lanes];

            for (int lane = 0; lane < lanes; lane++)
            {
                Console.Write("Enter time for lane " + (lane  + 1) + ": ");
                times[lane] = Convert.ToDouble(Console.ReadLine());
            }

            Array.Sort(times);

            for (int time = 0; time < times.Length; time++)
            {
                Console.WriteLine("Lane " + (time + 1) + " " + times[time]);

                if (gender == "male")
                {
                    if (times[time] < 9.58)
                        Console.WriteLine("World record");
                    else if (times[time] < 9.86)
                        Console.WriteLine("European record");
                    else if (times[time] < 9.87)
                        Console.WriteLine("British record");
                }
                else
                {
                    if (times[time] < 10.49)
                        Console.WriteLine("World record");
                    else if (times[time] < 10.73)
                        Console.WriteLine("European record");
                    else if (times[time] < 10.99)
                        Console.WriteLine("British record");
                }           
            }
            Console.ReadKey();        
        }
    }
}
