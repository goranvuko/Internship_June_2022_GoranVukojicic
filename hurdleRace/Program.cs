using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hurdleRace
{
    internal class Program
    {
        private static int hurdleRace(int k, int[] height)
        {
            int max = height[0];

            for (int i = 1; i < height.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                } 
            }
            return max - k;
        }
        static void Main(string[] args)
        {
            int k = 1;
            int[] height = { 1, 2, 3, 3, 2 };

            Console.WriteLine("Doses of potion a player need to take to be able to jump all of the hurdles:");
            Console.WriteLine(hurdleRace(k, height));
        }
    }
}
