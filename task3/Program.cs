using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Rudniev", "Vladyslav");
            employee.AddPosition(Position.Junior, 0);
            employee.Calculate();
        }
    }
}
