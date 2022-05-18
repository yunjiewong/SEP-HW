using System;

namespace Assignment2
{
	public class MostFrequent
	{
        public MostFrequent(int[] numbers){
            var dict = new Dictionary<int, int>();
            foreach (int i in numbers){
                int count = 0;
                dict.TryGetValue(i, out count);
                count++;
                dict[i] = count;
            }

            int maxItr = dict.Values.Max();
            var list = new List<int>();
            foreach(var e in dict){
                if(e.Value == maxItr)
                    list.Add(e.Key);
            }
            Console.WriteLine();
            if (list.Count == 1){
                Console.WriteLine($"The number {list[0]} is the most frequent (occurs {maxItr} times)");
            }
            else{
                int leftmost = list[0];
                list.Sort();
                Console.Write("The number");
                foreach(var i in list){
                    Console.Write(i+",");
                }
                
                 Console.Write($"have the same maximal frequence (each occurs {maxItr} times). The leftmost of them is {leftmost}.");
            }



        }
    }
}