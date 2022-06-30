using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class MostFrequent
    {
        public static void MostFrequentValue(int[] numbers)
        {
            var counts = new Dictionary<int, int>();
            foreach(int number in numbers)
            {
                int count;
                counts.TryGetValue(number, out count);
                count++;
                counts[number] = count;
            }
            int mostCommonValue = 0;
            int occurrences = 0;
            foreach(var pair in counts)
            {
                if(pair.Value > occurrences)
                {
                    occurrences = pair.Value;
                    mostCommonValue = pair.Key;
                }
            }
            Console.WriteLine($"The number {mostCommonValue} is most frequent (occurs {occurrences} times)");
        }
    }
}
