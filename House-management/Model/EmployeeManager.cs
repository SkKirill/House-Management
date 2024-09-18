using House_management.Model.Employees;

namespace House_management.Model;

public class EmployeeManager
{
    private List<Employee> _employees;

    public EmployeeManager()
    {
        _employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public void RemoveEmployee(Employee employee)
    {
        _employees.Remove(employee);
    }
}