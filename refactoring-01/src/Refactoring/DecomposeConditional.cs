namespace Refactoring;

public class DecomposeConditional
{
    public double CalculateMonthlySalary(Employee employee)
    {
        if (employee.WorkHoursThisMonth >= 160 && 
            employee.PerformanceRating >= 4 && 
            !employee.HasUnexcusedAbsences)
        {
            return (employee.WorkHoursThisMonth - 160) * ExtraHourValue  
                   + 160 * RegularHourValue;
        }
        return employee.WorkHoursThisMonth * RegularHourValue;
    }    
    
    public double CalculateMonthlySalaryRefactored(Employee employee)
    {
        return IsEligibleForBonus(employee) ? 
            CalculateBonusSalary(employee) : CalculateRegularSalary(employee);
    }
    
    private bool IsEligibleForBonus(Employee employee)
    {
        return employee.WorkHoursThisMonth >= 160 &&
               employee.PerformanceRating >= 4 &&
               !employee.HasUnexcusedAbsences;
    }
    
    private double CalculateBonusSalary(Employee employee)
    {
        return (employee.WorkHoursThisMonth - 160) * ExtraHourValue  + 160 * RegularHourValue;
    }

    public int RegularHourValue { get; set; }

    public int ExtraHourValue { get; set; }

    private double CalculateRegularSalary(Employee employee)
    {
        return employee.WorkHoursThisMonth * RegularHourValue;
    }
}