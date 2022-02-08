using System;
using System.Collections.Generic;

namespace StoneityDegerlendirme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = new List<int>()
            {
                4,13,8,9,7,1,6,20,15
            };

            List<int> outputNumbers1 = new List<int>();
            List<int> outputNumbers2 = new List<int>();
            var count = inputNumbers.Count;

            for (int i = 0; i < count; i++)
            {
                if(inputNumbers.Count > 0)
                {
                    if(inputNumbers.Count > 0)
                    {
                        var maxNumber = selectmaxnumber(inputNumbers); //inputNumbers.Max() fonsşyonuda kullanılabilir, Algoritma amacı ile yazdım
                        outputNumbers1.Add(maxNumber);
                        inputNumbers.Remove(maxNumber);
                    }

                    if (inputNumbers.Count > 0)
                    {
                        var maxNumber1 = selectmaxnumber(inputNumbers); //inputNumbers.Max() fonsşyonuda kullanılabilir, Algoritma amacı ile yazdım
                        outputNumbers2.Add(maxNumber1);
                        inputNumbers.Remove(maxNumber1);
                    }
                }
                else
                {
                    break;
                }
            }

            outputNumbers2.Reverse();
            outputNumbers1.AddRange(outputNumbers2);
            outputNumbers1.ForEach(i => Console.Write("{0}\t", i));
            Console.ReadKey();
        }

        private static int selectmaxnumber(List<int> list)
        {
            int maxValue = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if(maxValue < list[i])
                {
                    maxValue = list[i];
                }
            }
            return maxValue;
        }
    }
}
