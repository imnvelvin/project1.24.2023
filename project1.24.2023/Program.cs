using System;
using System.Globalization;
using System.Linq;

namespace project1._24._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            string str = " Elvin Imanov!";
            str = str.ToLower();
            Console.WriteLine(str);
            var word = str.Substring(0, 3);
            Console.WriteLine(word);
            Console.WriteLine(str.LastIndexOf("1"));
            Console.WriteLine(str.IndexOf("3"));
            Console.WriteLine(str.Substring(str.IndexOf(' ') + 1));



            str = str.Replace("Hello","World! ");
            str = "Salamlar,men Elvin!";
            str = str.Trim();

            str.StartsWith("Salamlar");
            str.EndsWith("niv");
            
            Console.WriteLine(str);
            Console.WriteLine(char.IsDigit('a'));
            Console.WriteLine(char.IsDigit('1'));
            Console.WriteLine(char.IsLetterOrDigit('e'));

            Console.WriteLine(char.IsLower('1'));
            Console.WriteLine(char.IsUpper('2'));
            Console.WriteLine(char.ToUpper('e'));


            string sentence = "Salam Millet necesiz";
            var wordsarr = sentence.Split(" ");

            var newSentence = string.Join(" + ", wordsarr);

            Console.WriteLine(newSentence);


            string name;

            do
            {
                Console.WriteLine("Ad Daxil Edin");
                name = Console.ReadLine();

            } while (!char.IsUpper(name[0]));

     







            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Contains("l"));
            Console.WriteLine(str.Contains("M"));

            int[] numbers = { 123, 32, 1, 7, 333, 975, 22, 19 };
            Console.WriteLine(Array.LastIndexOf(numbers, 19));

            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Array.Clear(numbers, 0, 2);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);

            }








            int number = 20;
            Addnumber(ref number);


            Console.WriteLine(number);






            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            findint(ref numbers, 5);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void findint(ref int[] arr, int num)
        {
            int[] newArr = new int[arr.Length + 1];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)

            {
                newArr[j] = arr[i];
                j++;


            }
            newArr[newArr.Length - 1] = num;

            arr = newArr;

        }
        static void Addnumber(ref int num)
        {
            num += 10;


        }
        static void findnumber(ref int num)
        {
            if (num < 0)
            {
                num = 0;
            }
            else if (num > 100)
            {
                num = 100;
            }
        }



    }

}
