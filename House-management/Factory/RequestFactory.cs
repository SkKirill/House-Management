using House_management.Model.Requests;

namespace House_management.Factory;

public class RequestFactory
{
    private int _nextId = 1;
    public Request CreateRequest(string description)
    {
        return new Request(_nextId++, description);
    }
}