namespace Refactoring;

class SeparateQueryFromModifier
{
    public List<Employee> Employees = new List<Employee>()
    {
        new Employee(){Name = "Matheus", Sales = 1000, Bonus = 0},
        new Employee(){Name = "Fernanda", Sales = 500, Bonus = 0}
    };
        
    public void Before()
    {
        Employee monthEmployee = GetMonthEmployeeAndSetBonus(Employees, 1500);
    }
    
    public void After()
    {
        Employee monthEmployee = GetMonthEmployee(Employees);
        SetBonusForMonthEmployee(monthEmployee, 1500);
    }
    
    public Employee GetMonthEmployeeAndSetBonus(List<Employee> employees, 
        decimal bonusAmount)
    {
        Employee monthEmployee = employees.MaxBy(employee => employee.Sales)!;
        monthEmployee.Bonus = bonusAmount;
        return monthEmployee;
    }

    public Employee GetMonthEmployee(List<Employee> employees)
    {
        return employees.MaxBy(employee => employee.Sales)!;
    }
    
    public void SetBonusForMonthEmployee(Employee employee, 
        decimal bonusAmount)
    {
        employee.Bonus = bonusAmount;
    }
}

public class Employee
{
    public string Name { get; set; }
    public int Sales { get; set; }
    public decimal Bonus { get; set; } = 0;
}