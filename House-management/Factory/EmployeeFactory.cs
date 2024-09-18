using House_management.Model.Employees;

namespace House_management.Factory;

public class EmployeeFactory
{
    public static IEmployee CreateEmployee(string name, string position)
    {
        switch (position)
        {
            case "Электрик":
                return new Electrician(name);
            case "Сантехник":
                return new Plumber(name);
            case "Дворник":
                return new Janitor(name);
            default:
                throw new ArgumentException("Неверная позиция.");
        }
    }
}