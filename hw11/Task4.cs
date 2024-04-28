
namespace hw11
{
    internal class Task4
    {
        public void Overturn()
        {
            Console.WriteLine("Enter the main file path:");
            string textFilePath = Console.ReadLine();

            if (!File.Exists(textFilePath))
            {
                Console.WriteLine("Error...");
                return;
            }

            string text = File.ReadAllText(textFilePath);
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            text = new string(charArray);

            Console.WriteLine("Enter the path to the output file:");
            string outputFilePath = Console.ReadLine();

            File.WriteAllText(outputFilePath, text);
        }
    }
}
