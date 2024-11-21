using System;
using System.Collections.Generic;

namespace Файлик
{
    internal class Program
    {
        public enum DayOftheWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            /*Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            упорядоченной по возрастанию. В случае отрицательного ответа определить
            порядковый номер первого числа, которое нарушает данную последовательность.
            Использовать break.*/
            Console.WriteLine("Задание 1");
            
            int[] massiv = new int[10]; //бахаем массив с произвольными числами
            bool flag = true;
            int problemIndex = -1;
            Console.WriteLine("Введите 10 целых чисел, нажимая Enter после каждого:"); //пользователь - дурак
            
            for (int i = 0; i < massiv.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out massiv[i]))
                {
                    Console.WriteLine("Некорректный ввод, попробуйте еще раз");
                    Console.WriteLine("Введите 10 целых чисел, нажимая Enter после каждого:");
                }
            }
            
            for (int i = 1; i < massiv.Length; i++)
            {
                if (massiv[i] < massiv[i - 1])
                {
                    flag = false;
                    problemIndex = i;
                    break;
                }
            }
            
            if (flag)
            {
                Console.WriteLine("Всё норм, последовательность упорядочена по возрастанию");
            }
            else
            {
                Console.WriteLine($"Последовательность не упорядочена по возрастанию. " + $"Первое число, нарущающее порядок, находится под номером: {problemIndex}");
            }
            Console.ReadLine();


            /*Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,...,7)
            выводит на экран его название(понедельник, вторник, ..., воскресенье).
            Использовать enum*/
            Console.WriteLine("Задание 4");
            
            Console.WriteLine("Введите порядковый номер дня недели от 1 до 7");
            string number = Console.ReadLine();
            bool Flag = true;
            while (Flag)
            {
                if (int.TryParse(number, out int dayNumber))
                {

                    if (dayNumber >= 1 && dayNumber <= 7)
                    {
                        DayOftheWeek day = (DayOftheWeek)dayNumber;
                        Console.WriteLine($"Введенный день недели: {day}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите число от 1 до 7.");
                        number = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка. Введите целое ЧИСЛО");
                    number = Console.ReadLine();
                }
            }
            Console.ReadLine();


            /*Создать массив строк. При помощи foreach обойти весь массив.При встрече элемента
            "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
            результату.Вывести на экран сколько кукол в “сумке”*/
            Console.WriteLine("Задание 5");
            
            string[] toys = { "Hello Kitty", "Matryoshka", "Barbie doll", "Car", "Hello Kitty", "Hello Kitty", "Barbie doll", "Domino" };
            List<string> BagforDolls = new List<string>(); //создадим список, чтобы класть туда кукол из массива
            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                    {
                        BagforDolls.Add(toy);
                    }
            }
            Console.WriteLine($"В сумке кукол барби и хеллоу кити: {BagforDolls.Count}"); //считаем количество кукол и выводим на экран
            Console.ReadLine();
            }
        }
    }

