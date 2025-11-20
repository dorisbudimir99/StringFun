using System;

namespace AssignmentStringData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a paragraph of text");
            string paragraph = Console.ReadLine();

            string[] words = paragraph.Split(" ");
            int wordsCount = words.Length;
            Console.WriteLine("Number of words in the paragraph: " + wordsCount);


            int vowelCount = 0;
            string vowels = "aeiouAEIOU";
            for ( int i = 0; i < paragraph.Length; i++ )
            {
                if (vowels.Contains(paragraph[i]))
                {
                    vowelCount++;
                }
  
            }
            Console.WriteLine("Number of Vowels in the paragraph: " + vowelCount);


            string[] freq = paragraph.ToLower().Split(new char[] {' ', '.', ',', '!', '?', ':', ';'}, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(freq);
            Console.WriteLine("\nWord Frequency (A-Z):");


            int count = 1;
            for( int i = 1;  i <= freq.Length; i++ )
            {
                if (i < freq.Length && freq[i] == freq[i - 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{freq[i-1]}: {count}");
                    count = 1;
                }
            }
           
      
        }
    }
}
