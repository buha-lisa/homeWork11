
namespace hw11
{
    internal class Task5
    {
        public void DigitAnalyze()
        {
            Random rnd = new Random();
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 1000000);
            }

            int Positive = 0;
            string filePath1 = @"Positive.txt";
            using (StreamWriter writer1 = new StreamWriter(filePath1, false))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]>=0)
                    {
                        writer1.WriteLine(array[i]);
                        Positive++;
                    }
                }
            }

            int Negative = 0;
            string filePath2 = @"Negative.txt";
            using (StreamWriter writer2 = new StreamWriter(filePath2, false))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        writer2.WriteLine(array[i]);
                        Negative++;
                    }
                }
            }

            int twoDigitCount = 0;
            string filePath3 = @"twoDigitCount.txt";
            using (StreamWriter writer3 = new StreamWriter(filePath3, false))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 10 && array[i] <= 99)
                    {
                        writer3.WriteLine(array[i]);
                        twoDigitCount++;
                    }
                }
            }
            int fiveDigitCount = 0;
            string filePath4 = @"fiveDigitCount.txt";
            using (StreamWriter writer4 = new StreamWriter(filePath4, false))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 10000 && array[i] <= 99999)
                    {
                        writer4.WriteLine(array[i]);
                        fiveDigitCount++;
                    }
                }
            }
            Console.WriteLine($"Number of positive numbers: {Positive}");
            Console.WriteLine($"Number of negative numbers: {Negative}");
            Console.WriteLine($"Number of two-digit numbers: {twoDigitCount}");
            Console.WriteLine($"Number of five-digit numbers: {fiveDigitCount}");
        }
    }
}
