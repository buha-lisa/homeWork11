
namespace hw11
{
    internal class Task2
    {
        public void SearchAndChange()
        {
            Console.WriteLine("Enter the file path:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error...");
                return;
            }

            string text = File.ReadAllText(filePath);
            Console.WriteLine("Enter the word to search:");
            string wordToSearch = Console.ReadLine();
            Console.WriteLine("Enter the word to change:");
            string wordToChange = Console.ReadLine();

            if (!text.Contains(wordToSearch))
            {
                Console.WriteLine("Error... Word is not in text");
                return;
            }

            int count = 0;
            int index = 0;
            while ((index = text.IndexOf(wordToSearch, index)) != -1)
            {
                count++;
                text = text.Remove(index, wordToSearch.Length).Insert(index, wordToChange);
                index += wordToSearch.Length;
            }
            Console.WriteLine($"Number of occurrences: {count}");
        }
    }
}
