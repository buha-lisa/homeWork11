
namespace hw11
{
    internal class Task1
    {
        public void FibonachiAndPrimeNum()
        {
            Random rnd = new Random();
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-1000, 1000);
            }

            int Fibonachi = 0;
            string filePath1 = @"Fibonachi.txt";
            using (StreamWriter writer1 = new StreamWriter(filePath1, false))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (Fibonacci(array[i]))
                    {
                        writer1.WriteLine(array[i]);
                        Fibonachi++;
                    }
                }
            }

            int PrimeNum = 0;
            string filePath2 = @"PrimeNum.txt";
            using (StreamWriter writer2 = new StreamWriter(filePath2, false))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (IsPrimeNumber(array[i]))
                    {
                        writer2.WriteLine(array[i]);
                        PrimeNum++;
                    }
                }
            }
            Console.WriteLine($"Fibonachi {Fibonachi}   -   Prime Numbers {PrimeNum}");
        }
        public bool IsPrimeNumber(int number)
        {
            bool result = true;
            if (number > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        public bool Fibonacci(int number)
        {   
            if (Math.Sqrt(5 * Math.Pow(number, 2) - 4) % 1 == 0 || Math.Sqrt(5 * Math.Pow(number, 2) + 4) % 1 == 0)
            {
                return true; 
            }
            return false;
        }
    }
}

