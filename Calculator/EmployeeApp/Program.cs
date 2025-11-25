using EmployeeApp;

Employee emp1 = new Employee("Andrii", 1000);
Employee emp2 = new Employee("Olena", 1500);

Employee emp3 = emp1 + 200;
Employee emp4 = emp2 - 300;

Console.WriteLine(emp3.ToString());
Console.WriteLine(emp4);

Console.WriteLine(emp3 == emp4);
Console.WriteLine(emp3 != emp4);
Console.WriteLine(emp1 < emp2);
Console.WriteLine(emp2 > emp1);

