using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite dlinnu massiva:");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int sumpol = 1;
            int sumotr = 1;
            int[] nums = new int[lenght];
            for(int i = 0;i < lenght; i++)
            {
                Console.WriteLine($"Vvedite cislo po indexu {i}:");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    sumpol = nums[i] * sumpol;
                }
                if (nums[i] < 0)
                {
                    sumotr = nums[i] * sumotr;
                }
            }
            if(Math.Abs(sumotr) > sumpol)
            {
                Console.WriteLine(sumotr);
            }
            else
            {
                Console.WriteLine(sumpol);
            }
        }
    }
}
