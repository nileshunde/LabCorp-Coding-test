Write classes in C# represent 3 different types of Employee – hourly employees, salaried employees, and
managers (also considered salaried employees)
Each employee has a floating-point property for number of vacation days accumulated for the work year
(defined as 260 workdays) which cannot be a negative value and is not writable externally. Upon
creation its value should be set to 0.
Hourly employees accumulate 10 vacation days during the work year.
Salaried employees accumulate 15 vacation days during the work year.
Managers accumulate 30 vacation days during the work year.
Each employee has a Work() method that takes a single integer parameter that defines the number of
days worked which should be a value between 0 and 260. When this method is called, the number of
vacation days accumulated should be updated appropriately.
Each employee also has a TakeVacation() method that takes a single floating-point parameter that
defines the number of vacation days used. When this method is called, the number of vacation days
accumulated should be updated appropriately.
An employee cannot work more than the number of workdays in a work year and cannot take more
vacation than is available.
Unit tests should prove the correctness of the code. At a minimum, the methods for Work() and
TakeVacation() should have tests that check for corner cases.
Tools and technologies
C#: Visual Studio or Visual Studio Code
