namespace Module04_WorkWithVariableDataInC_ConsoleApplications
{
    public static class ReverseWordsInASentenceChallange
    {
        public static void Run()
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] words = pangram.Split(' ');

             string[] reversedWords = new string[words.Length];

            for (int i= 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();
                Array.Reverse(letters);
                reversedWords[i] = new string(letters);               
            }
            string result = String.Join(" ", reversedWords);
            Console.WriteLine(result);
        }
    }
}
