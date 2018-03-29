using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _329practicce
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "a", "b", "a", "b", "a", "b", "a" };
            string[] type = { "AB", "IA", "IB", "II", "IA", "II", "II" };

            //
            int count = 0;

            for (int x = 0; x < name.Length; x++)
            {
                if (name[x] == "b")
                {
                    count += 1;
                }
            }

            Console.WriteLine("the number of b is:" + count);

            //to count the number of a or b

            int countA = 0;
            int countB = 0;

            for (int z = 0; z < name.Length; z++)
            {
                if (name[z] == "a")
                {
                    countA++;
                }
            }

            double persentA = ((double)countA / (double)name.Length) * 100;


            Console.WriteLine("the persentage of a is:"+"  " + persentA);
            Console.WriteLine("the number a :" + countA);

            //


            int[] height = { 140, 160, 170, 168, 180, 190, 190 };
            int sum = 0;

            for (int i = 0; i < height.Length; i++)
            {
                if (name[i] == "b")
                {
                    sum = sum + height[i];
                    count++;
                }
            }
            Console.WriteLine("the total of heightB is :" + sum);
            //

            for (int i = 0; i < height.Length; i++)
            {

                if (name[i] == "b")
                {
                    countB++;   
                }
            }
            int averageB;
            averageB = sum / countB;
            Console.WriteLine("the average of heightB is :" + averageB);

            //%pic

            for (int i = 0; i < 40; i++)
            {

            }

            //find out themax of height
            
            int max = 0;//要設定越小越好
            int min = 200;//設定大一點

            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                }
                if (height[i] < min)
                {
                    min = height[i];
                }

            }
            Console.WriteLine("the max of heightB is :" + max);
            Console.WriteLine("the min of heightB is :" + min);


            Console.ReadLine();

        }
    }
}
