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
	         Input Format

			The first line contains an integer,  (the number of integers in ). 
			The second line contains  space-separated integers describing .

			Output Format

			Print all  integers in  in reverse order as a single line of space-separated integers.

			Sample Input:
			4
			1 2 3 4

			Sample Output:
			4 3 2 1
			
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
