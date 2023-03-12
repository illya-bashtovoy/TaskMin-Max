using System;
using System.Linq;

namespace TaskExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] task = { 5, 12, 3, 8, 9, 2, 4, 10, 1, 7 };

            int мінімум = task.Min(); // отримуємо мінімальне значення в масиві
            int максимум = task.Max(); // отримуємо максимальне значення в масиві
            double середнєАрифметичне = task.Average(); // отримуємо середнє арифметичне значення в масиві
            int сума = task.Sum(); // отримуємо суму значень в масиві

            Console.WriteLine("Мінімум: " + мінімум);
            Console.WriteLine("Максимум: " + максимум);
            Console.WriteLine("Середнє арифметичне: " + середнєАрифметичне);
            Console.WriteLine("Сума: " + сума);
        }
    }
}