using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Test
{
    class MainClass
    {
        /*
         * Reverse then Print, Array of Ints
        */
        public static void Main(string[] args)
        {
            Console.ReadLine();
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            if(arr != null && arr.Count()>0)
            {
				var numberList = arr.ToList(); 
				numberList.Reverse();
				string output = string.Empty; 
				numberList.ForEach(number =>
				{
					output += string.Format("{0} ", number);
				});
				output = output.TrimEnd();
				Console.WriteLine(output);
				Console.ReadKey();
            }

        }
    }
}
