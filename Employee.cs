using System;

public abstract class Employee
{
    private float vacationDaysAccumulated;

    public float VacationDaysAccumulated
    {
        get { return vacationDaysAccumulated; }
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Vacation days cannot be negative.");
            vacationDaysAccumulated = value;
        }
    }

    public Employee()
    {
        VacationDaysAccumulated = 0;
    }

    public abstract void Work(int daysWorked);

    public void TakeVacation(float days)
    {
        if (days < 0)
            throw new ArgumentException("Vacation days cannot be negative.");
        if (days > VacationDaysAccumulated)
            throw new InvalidOperationException("Cannot take more vacation than accumulated.");

        VacationDaysAccumulated -= days;
    }
}
