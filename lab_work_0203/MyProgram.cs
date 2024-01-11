using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_0203
{
    enum Vacancies : byte
    {
        Manager = 1, Boss, Clerk, Salesman
    }

    struct Employee
    {
        public const int value = 3;
        string name;
        Vacancies vacancies;
        int salary;        
        int[] hiredat;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Vacancies Vacancies 
        {
            get { return vacancies; }
            set { vacancies = value; }
        }
        public int[] Hiredat { get { return hiredat; } }

        public Employee(string Name, Vacancies Vacancies, int Salary, int[] Hiredat)
        {
            name = Name;
            vacancies = Vacancies;
            salary = Salary;
            hiredat = Hiredat;
        }

        public string AddName()
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = Console.ReadLine();
            return name;
        }

        public Vacancies AddVacancies()
        {
            Console.WriteLine("Выберете вакансию:\n" +
                " 1 - Manager\n" +
                " 2 - Boss\n" +
                " 3 - Clerk\n" +
                " 4 - Salesman");
            int count = int.Parse(Console.ReadLine());
            vacancies = (Vacancies)count;
            Console.WriteLine(vacancies);
            return vacancies;
        }

        public int AddSalary()
        {
            Console.WriteLine("Введите заработную плату сотрудника:");
            int salary = int.Parse(Console.ReadLine());
            return salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} | Вакансия:{Vacancies} | Зарплата:{Salary} | Дата_приеиа:{ToString()}");
        }

        public int[] Hiredate()
        {
            hiredat = new int[value];
            Console.WriteLine("Ведите дату");
            for (int i = 0; i < hiredat.Length; i++)
            {
                
                bool key = true;
                while (key)
                {
                    try { hiredat[i] = int.Parse(Console.ReadLine()) ; if (hiredat[i] > 0 && ((i == 0 && hiredat[i] <= 30) || (i == 1 && hiredat[i] <= 12 && hiredat[i] != 2) || (i == 1 && hiredat[i] == 2 && hiredat[0] < 29) || (i == 2))) key = false; else Console.WriteLine("Вы ввели недопустимое значение"); }
                    catch { Console.WriteLine("Вы ввели недопустимое значение"); }
                }
                Console.Clear();
            }
            return hiredat;
        }

        public override string ToString()
        {
            string s = "( ";
            for (int i = 0; i < Hiredat.Length; i++)
            {
                s += Hiredat[i] + " ";
            }
            s += ")";
            return s;
        }
    }



    internal class MyProgram
    {
        static void Main(string[] args)
        {
            Employee employees = new Employee();

            Console.WriteLine("Введите количество сотрудников:");
            int n = Exception.Exception_1();
            Employee[] arr_employee = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                arr_employee[i] = new Employee(employees.AddName(), employees.AddVacancies(), employees.AddSalary(), employees.Hiredate());
            }

            Console.WriteLine("Выберете режим работы:\n" +
                    "1 - Вывести полную информацию обо всех сотрудниках\n" +
                    "2 - Вывести полную информацию о сотрудниках, работающих в должности\n" +
                    "3 - Найти в массиве всех менеджеров\n" +
                    "4 - Вывести полную информацию обо всех сотрудниках, принятых на работу позже босса, " +
                    "отсортированную в алфавитном порядке по фамилии сотрудника\n");
            int k = int.Parse(Console.ReadLine());
            while (k != 0)
            { 
                switch (k)
                {
                    case 1:
                        {
                            foreach (var users in arr_employee)
                                users.DisplayInfo();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Выберете вакансию:\n" +
                                            " 1 - Manager\n" +
                                            " 2 - Boss\n" +
                                            " 3 - Clerk\n" +
                                            " 4 - Salesman");
                            int qq = int.Parse(Console.ReadLine());
                            Vacancies cvacancies = (Vacancies)qq;

                            for (int i = 0; i < arr_employee.Length; i++)
                            {
                                if (arr_employee[i].Vacancies == cvacancies)
                                {
                                    arr_employee[i].DisplayInfo();
                                }
                            }

                            if (arr_employee.Length == 0)
                            {
                                Console.WriteLine("В списке сотрудников введённой вакансии нет\n");
                            }
                        
                            break;
                        }
                    case 3:
                        {
                            List<Employee> list = new List<Employee>();
                            int count = 0;
                            int summ = 0;
                            for (int i = 0; i < arr_employee.Length; i++)
                            {
                                if (arr_employee[i].Vacancies == Vacancies.Clerk)
                                {
                                    summ =+ arr_employee[i].Salary;
                                    count++;
                                }
                            }

                            if (count == 0)
                            {
                                Console.WriteLine("Менеджеров, зарплата которых больше средней зарплаты клерков нет\n");
                            }

                            else
                            {
                                int average = summ / count;

                                for (int i = 0; i < arr_employee.Length; i++)
                                {
                                    if (arr_employee[i].Vacancies == Vacancies.Manager && arr_employee[i].Salary > average)
                                    {
                                        arr_employee[i].DisplayInfo();
                                        list.Add(arr_employee[i]);
                                    }
                                }


                                for (int i = 0; i < list.Count - 1; i++)
                                {
                                    for (int j = i + 1; j < list.Count; j++)
                                    {
                                        if (list[i].Name.CompareTo(list[j].Name) > 0)
                                        {
                                            var cur = list[i];
                                            list[i] = list[j];
                                            list[j] = cur;
                                        }
                                    }
                                }

                                for (int i = 0; i < list.Count; i++)
                                {
                                    list[i].DisplayInfo();
                                }
                            }

                            break;
                        }

                    case 4:
                        {
                            List<Employee> list = new List<Employee>();
                            List<Employee> _list = new List<Employee>();

                            for (int i = 0; i < arr_employee.Length; i++)
                            {
                                if (arr_employee[i].Vacancies == Vacancies.Boss)
                                {
                                    _list.Add(arr_employee[i]);                                    
                                }
                            }

                            if (_list.Count > 0)
                            {
                                for (int i = 0; i < arr_employee.Length; i++)
                                {
                                    if (arr_employee[i].Vacancies != Vacancies.Boss)
                                    {
                                        if (_list[0].Hiredat[2] < arr_employee[i].Hiredat[2])
                                        {
                                            list.Add(arr_employee[i]);
                                        }
                                        if (_list[0].Hiredat[2] == arr_employee[i].Hiredat[2] && _list[0].Hiredat[1] < arr_employee[i].Hiredat[1])
                                        {
                                            list.Add(arr_employee[i]);
                                        }
                                        if (_list[0].Hiredat[2] == arr_employee[i].Hiredat[2] && _list[0].Hiredat[1] == arr_employee[i].Hiredat[1] && _list[0].Hiredat[0] < arr_employee[i].Hiredat[0])
                                        {
                                            list.Add(arr_employee[i]);
                                        }
                                    }
                                }

                                for (int i = 0; i < list.Count - 1; i++)
                                {
                                    for (int j = i + 1; j < list.Count; j++)
                                    {
                                        if (list[i].Name.CompareTo(list[j].Name) > 0)
                                        {
                                            var cur = list[i];
                                            list[i] = list[j];
                                            list[j] = cur;
                                        }
                                    }
                                }

                                for (int i = 0; i < list.Count; i++)
                                {
                                    list[i].DisplayInfo();
                                }
                            }

                            else
                            {
                                Console.WriteLine("Увы, Босс на работе отсутствует");
                            }

                            

                            break;
                        } 

                }
                Console.WriteLine("Выберете режим работы:\n" +
                    "1 - Вывести полную информацию обо всех сотрудниках\n" +
                    "2 - Вывести полную информацию о сотрудниках, работающих в должности\n" +
                    "3 - Найти в массиве всех менеджеров\n" +
                    "4 - Вывести полную информацию обо всех сотрудниках, принятых на работу позже босса, " +
                    "отсортированную в алфавитном порядке по фамилии сотрудника\n");

                k = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
