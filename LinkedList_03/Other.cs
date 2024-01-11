using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_03
{
    internal class Other
    {
        public void Menu()
        {
            Console.WriteLine("Лабораторная работа №3.\n" +
                  "Выполнил студент группы 6202 Боряков Никита\n ");
            
            Console.WriteLine("Выберете пункт\n" +
                                "0 - Настройка списка\n" +
                                "1 - Задание 1\n" +
                                "2 - Задание 3\n" +
                                "3 - Задание 5\n" +                                
                                "4 - Выход из программы\n");
        }

        public void Settings() 
        {
            Console.WriteLine("\nВыберете пункт\n" +                                
                                "1 - Добавление элемента в конец\n" +
                                "2 - Добавление элемента в начало\n" +
                                "3 - Удаление первого выбранного элемента\n" +
                                "4 - Удаление конечного элемента\n" +
                                "5 - Удаление начального элемента\n" +
                                "6 - Выход из настроек\n");
        }
        public void Add() 
        {
            Console.WriteLine("Введите элемент: ");
        }
    }
}
