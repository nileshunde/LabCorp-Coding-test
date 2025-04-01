using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.Work(260);
            Console.WriteLine($"Hourly Employee Vacation Days: {hourlyEmployee.VacationDaysAccumulated}");

            Employee salariedEmployee = new SalariedEmployee();
            salariedEmployee.Work(260);
            Console.WriteLine($"Salaried Employee Vacation Days: {salariedEmployee.VacationDaysAccumulated}");

            Employee manager = new Manager();
            manager.Work(260);
            Console.WriteLine($"Manager Vacation Days: {manager.VacationDaysAccumulated}");

            hourlyEmployee.TakeVacation(5);
            Console.WriteLine($"Hourly Employee Vacation Days after taking vacation: {hourlyEmployee.VacationDaysAccumulated}");
        }
    }
}
