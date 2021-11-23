using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определение, является ли введенная строка палиндромом без учета регистра и пробелов
            #region Ввод исходных данных, переформатирование введенной строки
            string str = Console.ReadLine().ToUpper().Replace(" ", "");
            bool palindrome = true;
            #endregion

            #region Исследование строки
            while (str.Length > 1)
            {
                if (!str.EndsWith(str.Substring(0, 1)))
                {
                    palindrome = false;
                    break;
                }
                else
                {
                    str = str.Substring(1, str.Length-2);
                }
            }
            #endregion

            Console.WriteLine(palindrome?"Введенная строка является палиндромом":"Введенная строка не является палиндромом");
            Console.ReadKey();
        }
    }
}
