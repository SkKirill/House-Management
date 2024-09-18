using House_management.Model.Employees;

namespace House_management.Model.Requests;

public class Request
{
    public int Id { get; }
    public string Description { get; }
    public RequestStatus Status { get; set; }
    public IEmployee AssignedEmployee { get; set; }

    public Request(int id, string description)
    {
        Id = id;
        Description = description;
        Status = RequestStatus.Created;
    }
}