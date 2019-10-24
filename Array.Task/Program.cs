using System;

namespace Array.Task
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = new int[101];
			int sum = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = 0 + i;
				Console.WriteLine(numbers[i]);
			}

			foreach (var item in numbers)
			{
				sum += item;
			}
			Console.WriteLine($"Kõikide numbrite kogusumma on: {sum}");
		}
    }
}
