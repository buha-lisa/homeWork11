namespace hw11
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-5): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        new Task1().FibonachiAndPrimeNum();
                        break;
                    case 2:
                        new Task2().SearchAndChange();
                        break;
                    case 3:
                        new Task3().Moderator();
                        break;
                    case 4:
                        new Task4().Overturn();
                        break;
                    case 5:
                        new Task5().DigitAnalyze();
                        break;
                }

                if (task == 0) break;
            }
        }
    }
}
