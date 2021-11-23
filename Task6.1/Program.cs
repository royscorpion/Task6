using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поиск самого длинного слова в введенной строке
            #region Исходные данные
            string str = Console.ReadLine(), longWord = "";
            string[] stringArray = str.Split();
            int strLen, strMaxLen = 0;
            #endregion

            #region Разбивка строки на отдельные слова, определение самого длинного слова
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (strMaxLen < (strLen = stringArray[i].Length))
                {
                    strMaxLen = strLen;
                    longWord = stringArray[i];
                }
            }
            #endregion

            //Вывод результатов
            Console.WriteLine("Самое длинное слово в введеной строке - {0}\nДлина слова - {1} символов", longWord,strMaxLen);
            Console.ReadKey();
        }
    }
}
