using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
amespace lab_work_0203
{

    /*
     * 
     
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Объявление структурной переменной
            Employee employee = new Employee();


            // Количество сотрудников 
            Console.WriteLine("Введите количество сотрудников:");
            int n = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                employees[i] = new Employee(employee.Name(), employee.Vacancies(), employee.Salary(), employee.Hiredate());
            }


            int q = int.Parse(Console.ReadLine());
            Vacancies narrov_vacancies = (Vacancies)q;
            for (int i = 0; i < n; i++)
            {
                if (narrov_vacancies = vacancies)
                {

                }
                employees[i] = new Employee(employee.Name(), employee.Vacancies(), employee.Salary(), employee.Hiredate());
            }

            // Вывод сотрудников
            foreach (var users in employees)
            {
                users.DisplayInfo();
            }

            Console.ReadLine();
        }
    }

    enum Vacancies : byte
    {
        Manager = 1, Boss, Clerk, Salesman
    }

    struct Employee
    {
        public string name;
        public Vacancies vacancies;
        public int salary;
        public const int value = 3;
        public int[] hiredat;

        
        public Employee(string name, Vacancies vacancies, int salary, int[] hiredat)
        {
            this.name = name;
            this.vacancies = vacancies;
            this.salary = salary;
            this.hiredat = hiredat;
        }        

        public void DisplayInfo()
        {
            Console.WriteLine($"{name} | Вакансия:{vacancies} | Зарплата:{salary} | Дата_приеиа:{ToString()}");
        }

        // Дата
        public int[] Hiredate()
        {
            hiredat = new int[value];
            Console.WriteLine("Ведите дату");
            for (int i = 0; i < hiredat.Length; i++)
            {
                hiredat[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            return hiredat;
        }

        public void Arbeit()
        {
            string str = Console.ReadLine();
            
            Vacancies vacancies = (Vacancies)Enum.Parse(typeof(Vacancies), str, ignoreCase: true);

            Console.WriteLine(vacancies);
        }

        public void Worker()
        {
            var values = Enum.GetNames(typeof(Vacancies));
            string s = "{ ";
            foreach (var v in values)
            {
                s += v + " ";
            }
            Console.WriteLine(s + "}");
        }
        
        // Имя
        public string Name()
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = Console.ReadLine();
            return name;
        }

        // Вакансия
        public Vacancies Vacancies()
        {
            Console.WriteLine("Выберете вакансию:\n" +
                " 1 - Manager\n" +
                " 2 - Boss\n" + 
                " 3 - Clerk\n" +
                " 4 - Salesman");
            int vv = int.Parse(Console.ReadLine());
            vacancies = (Vacancies)vv;
            Console.WriteLine(vacancies);
            return vacancies;
        }

        public void CompareVacancies()
        {
            int q = int.Parse(Console.ReadLine());
            Vacancies narrov_vacancies = (Vacancies)q;

            if (narrov_vacancies == vacancies)
            {
                for (int i = 0; i < length; i++)
                {

                }
            }
        }

        // Зарплата
        public int Salary()
        {
            Console.WriteLine("Введите заработную плату сотрудника:");
            int salary = int.Parse(Console.ReadLine());
            return salary;
        }

        // Вывод массива даты на консоль
        public override string ToString()
        {

            string s = "( ";
            for (int i = 0; i < hiredat.Length; i++)
            {
                s += hiredat[i] + " ";
            }
            s += ")";
            return s;
        }
    }
}
for (int l = 0; l < 3; l++)
                {
                    bool key = true;
                    while (key)
                    {
                        try { employee[l] = Convert.ToInt32(Console.ReadLine()); if (employee[l]>0 && ((l==0 && employee[l] <= 30) || (l == 1 && employee[l] <= 12 && employee[l] != 2) || (l == 1 && employee[l] == 2 && employee[0]<29) || (l==2))) key = false; else Console.WriteLine("Вы ввели недопустимое значение"); }
                        catch { Console.WriteLine("Вы ввели недопустимое значение"); }
                    }
                }

*/