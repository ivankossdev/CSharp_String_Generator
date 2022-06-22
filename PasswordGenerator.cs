using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    /*Класс генератора пароля*/
    public class PasswordGenerator
    {
        /* Инициализация переменных */
        private Random radomNumber = new Random();
        private List<char> outLine = new List<char>();
        private int lenghtArray;
        private List<char> passwordArray = new List<char>()
        {
            '0','1', '2', '3', '4', '5', '6', '7', '8', '9','a', 'b', 'c', 'd', 'e', 'f'
        };
        public PasswordGenerator()
        {
            /* Конструктор класса с значеними по умолчанию длина строки 10 символов*/
            const int defaultLenght = 10;
            lenghtArray = defaultLenght;
        }

        public PasswordGenerator(int lenght)
        {
            /* Конструктор класса с произовльной длиной символов*/
            lenghtArray = lenght;
        }

        public string generationString()
        {
            for (int x = 0; x < lenghtArray; x++)
            {
                outLine.Add(passwordArray[radomNumber.Next(0, passwordArray.Count)]);
            }
            return string.Join("", outLine); //Конвертация листа с сиволами в строку
        }
    }
}
