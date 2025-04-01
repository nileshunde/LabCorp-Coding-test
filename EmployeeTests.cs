using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void HourlyEmployee_Work_AccumulatesVacationDays()
    {
        var employee = new HourlyEmployee();
        employee.Work(260);
        Assert.AreEqual(10, employee.VacationDaysAccumulated);
    }

    [TestMethod]
    public void SalariedEmployee_Work_AccumulatesVacationDays()
    {
        var employee = new SalariedEmployee();
        employee.Work(260);
        Assert.AreEqual(15, employee.VacationDaysAccumulated);
    }

    [TestMethod]
    public void Manager_Work_AccumulatesVacationDays()
    {
        var employee = new Manager();
        employee.Work(260);
        Assert.AreEqual(30, employee.VacationDaysAccumulated);
    }

    [TestMethod]
    public void Employee_TakeVacation_ReducesVacationDays()
    {
        var employee = new HourlyEmployee();
        employee.Work(260);
        employee.TakeVacation(5);
        Assert.AreEqual(5, employee.VacationDaysAccumulated);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Employee_TakeVacation_ThrowsWhenTakingMoreThanAccumulated()
    {
        var employee = new HourlyEmployee();
        employee.Work(260);
        employee.TakeVacation(15);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Employee_Work_ThrowsWhenDaysWorkedOutOfRange()
    {
        var employee = new HourlyEmployee();
        employee.Work(300);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Employee_TakeVacation_ThrowsWhenNegativeDays()
    {
        var employee = new HourlyEmployee();
        employee.TakeVacation(-5);
    }
}
