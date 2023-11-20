using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для преобразования: ");
            //Считываем строку которую нелбходимо преодразовать
            string str = Console.ReadLine();


            //Переменная для последнего слова
            string lastWord = "";
            //Инициализируем массив слов
            List<string> listWords = new List<string>();
            //получаем последнее слово и записываем все слова в массив
            foreach (string line in str.Split(' '))
            {
                lastWord = line;
                listWords.Add(line);
            }
            Console.WriteLine("Результат для преобразования: ");
            //пробегаем массив слов n-1 раз (кроме последнего слова)
            for (int i = 0; i < listWords.Count - 1; i++)
            {
                //если текущее слово отлично от последнего
                //Если нужно без учета регистра
                if (!listWords[i].Equals(lastWord))
                //если нужно с учетом регистра
                //if(!listWords[i].ToLower().Equals(lastWord.ToLower())
                {
                    //записываем слово во временную переменную
                    string tmp = listWords[i];
                    if (tmp.Length > 2)
                    {
                        //получаем первую букву
                        string letter1 = tmp.Substring(0, 1);
                        //получаем последуюю букву
                        string letterlast = tmp.Substring(tmp.Length - 1, 1);
                        //обрезаем первую и последунюю буквы
                        tmp = tmp.Substring(1, tmp.Length - 2);
                        //формируем слово под текущие требования
                        tmp = $"{letterlast}{tmp}{letter1}";
                    }
                    //формируем результат
                    Console.Write(tmp + " ");

                }
            }
            Console.ReadLine();
            //Сложность порядка O(n)

        }

      
    }
}
