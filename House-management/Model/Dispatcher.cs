using House_management.Exceptions;
using House_management.Model.Employees;
using House_management.Model.Requests;

namespace House_management.Model;

public class Dispatcher
{
    private List<Employee> _employees;
    private List<Request> _requests;

    public Dispatcher(List<Employee> employees, List<Request> requests)
    {
        _employees = employees;
        _requests = requests;
    }

    public Request CreateRequest(string description)
    {
        int id = _requests.Count + 1;
        Request request = new Request(id, description);
        _requests.Add(request);
        return request;
    }

    public void AssignRequest(Request request, IEmployee employee)
    {
        if (employee.IsAvailable)
        {
            employee.AssignRequest(request);
            request.Status = RequestStatus.Assigned;
            request.AssignedEmployee = employee;
        }
        else
        {
            throw new DispatcherException("Сотрудник уже занят.");
        }
    }

    public void CompleteRequest(Request request)
    {
        if (request.AssignedEmployee != null)
        {
            request.AssignedEmployee.CompleteRequest();
            request.Status = RequestStatus.Completed;
        }
        else
        {
            throw new DispatcherException("Заявка не назначена.");
        }
    }
}