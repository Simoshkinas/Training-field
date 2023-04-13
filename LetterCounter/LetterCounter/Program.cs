namespace LetterCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] sortedChars = input.ToCharArray();

            Dictionary<char, int> charCounts = new();

            foreach (char c in sortedChars)
            {
                if(charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }
            var chars = new List<string>();
            foreach (KeyValuePair<char, int> charCount in charCounts)
            {
                if (charCount.Value > 1)
                {
                    chars.Add(charCount.Key + "" + charCount.Value);
                }
                else
                {
                    chars.Add(charCount.Key + "");
                }
            }
            for (int i = 0; i < chars.Count; i++)
            {
                Console.Write(chars[i]);
            }
        }
    }
}