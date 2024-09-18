using House_management.Exceptions;
using House_management.Model.Requests;

namespace House_management.Model.Employees;

public abstract class Employee : IEmployee
{
    public string Name { get; }
    public string Position { get; }
    public bool IsAvailable { get; set; } = true;
    public Request CurrentRequest { get; private set; }

    protected Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public void AssignRequest(Request request)
    {
        if (!IsAvailable)
        {
            throw new EmployeeException("Сотрудник уже занят.");
        }

        CurrentRequest = request;
        IsAvailable = false;
    }

    public void CompleteRequest()
    {
        if (CurrentRequest == null)
        {
            throw new EmployeeException("У сотрудника нет назначенной заявки.");
        }

        CurrentRequest.Status = RequestStatus.Completed;
        IsAvailable = true;
        CurrentRequest = null;
    }
}