using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Employee
    {
        private string _lName, _fName;
        private byte experience;
        private Position position;

        public string LName { get => _lName; set => _lName = value; }
        public string FName { get => _fName; set => _fName = value; }
        internal Position Position => position;
        public byte Experience { get => experience; set => experience = value; }

        public Employee() => position = Position.None;
        public Employee(string lname, string fname)
        {
            this.LName = lname;
            this.FName = fname;
            position = (Position)1;
            experience = 0;
        }

        public void AddPosition(Position position, byte experience)
        {
            this.position = position;
            this.experience = experience;
        }
        public void Calculate()
        {
            double salary = 0;
            switch((byte)Position)
            {
                case 0:
                    salary = 0;
                    break;
                case 1:
                    salary = 200;
                    break;
                case 2:
                    salary = 500;
                    break;
                case 3:
                    salary = 1000;
                    break;
                case 4:
                    salary = 2000;
                    break;
            }
            if (experience < 10)
                salary += experience * 100;
            else
                salary += 1000;

            Console.WriteLine("Имя Фамилия сотрудника: " + FName + " " + LName + ";");
            Console.WriteLine("Должность: " + position + ";");
            Console.WriteLine("Оклад сотрудника: " + salary + "usd;");
            Console.WriteLine("Налог: " + (salary * 0.2) + "usd.");
        }
    }
}
