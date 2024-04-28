
namespace hw11
{
    internal class Task3
    {
        public void Moderator()
        {
            Console.WriteLine("Enter the main file path:");
            string textFilePath = Console.ReadLine();
            Console.WriteLine("Enter the moderation file path:");
            string moderationFilePath = Console.ReadLine();

            if (!File.Exists(textFilePath) || !File.Exists(moderationFilePath))
            {
                Console.WriteLine("Error...");
                return;
            }

            string[] moderationWords = File.ReadAllLines(moderationFilePath);

            string text = File.ReadAllText(textFilePath);

            foreach (string word in moderationWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            File.WriteAllText(textFilePath, text);
        }
    }
}
