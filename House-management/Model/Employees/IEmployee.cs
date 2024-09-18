using House_management.Model.Requests;

namespace House_management.Model.Employees;

public interface IEmployee
{
    string Name { get; }
    string Position { get; }
    bool IsAvailable { get; set; }
    void AssignRequest(Request request);
    void CompleteRequest();
}