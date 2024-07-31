using System;

class Program
{
        static void Main(string[] args)
        {
		string word = "Holberton";
		string word_first_3 = word.Substring(0, 3); // Extract first 3 letters
		string word_last_2 = word.Substring(word.Length - 2); // Extract last 2 letters
                string middle_word = word.Substring(1, word.Length - 2); // Extract middle letters
		Console.WriteLine("First 3 letters: {0}", word_first_3);
                Console.WriteLine("Last 2 letters: {0}", word_last_2);
                Console.WriteLine("Middle word: {0}", middle_word);
        }
}
