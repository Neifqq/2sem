using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        // Было лень морочиться с ретурнами в цикле, поэтому сделал метод.
        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.ToCharArray().Length / 2; i++)
            {
                if (word.ToCharArray()[i] != word.ToCharArray()[word.ToCharArray().Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {

            int wordNumber = 0, aLetterNumberInLast = 0, aLetterNumberInPenultimate = 0, startsWithB = 0, palindromeNumber = 0;
            string lastWord = null, penultimateWord = null, aWord = null;
            try
            {
                using (FileStream stream = File.Open("file.txt", FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        while (reader.ReadLine() != null)
                        {
                            foreach (string word in reader.ReadLine().ToLower().Split(' '))
                            {
                                // Запоминаем предпоследнее и последнее слово.
                                penultimateWord = lastWord;
                                lastWord = word;
                                // Счётчик слов.
                                wordNumber++;
                                // Начинаются с "б".
                                if (word.ToCharArray()[0] == 'б')
                                {
                                    startsWithB++;
                                }
                                // Первое слово с буквой "а".
                                if (aWord != null)
                                {
                                    for (int i = 0; i < word.ToCharArray().Length; i++)
                                    {
                                        if (word.ToCharArray()[i] == 'а')
                                        {
                                            aWord = word;
                                            break;
                                        }
                                    }
                                }
                                if (IsPalindrome(word))
                                {
                                    palindromeNumber++;
                                }

                            }
                        }
                    }
                }
                for (int i = 0; i < lastWord.ToCharArray().Length; i++)
                {
                    if (lastWord.ToCharArray()[i] == 'a')
                    {
                        aLetterNumberInLast++;
                    }
                }
                for (int i = 0; i < penultimateWord.ToCharArray().Length; i++)
                {
                    if (penultimateWord.ToCharArray()[i] == 'a')
                    {
                        aLetterNumberInPenultimate++;
                    }
                }
                Console.WriteLine("Кол-во палиндромов");
                Console.WriteLine(palindromeNumber);
                Console.WriteLine("Кол-во слов");
                Console.WriteLine(wordNumber);
                Console.WriteLine("Слов с буквой а");
                Console.WriteLine(aWord);
                Console.WriteLine("Начинается с Б");
                Console.WriteLine(startsWithB);
                Console.WriteLine("Кол-во А в последнем слове");
                Console.WriteLine(aLetterNumberInLast);
                Console.WriteLine("Кол-во А в предпоследнем слове");
                Console.WriteLine(aLetterNumberInPenultimate);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
