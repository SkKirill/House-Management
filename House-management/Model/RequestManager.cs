using House_management.Model.Requests;

namespace House_management.Model;

public class RequestManager
{
    private List<Request> _requests;

    public RequestManager()
    {
        _requests = new List<Request>();
    }

    public void AddRequest(Request request)
    {
        _requests.Add(request);
    }

    public void RemoveRequest(Request request)
    {
        _requests.Remove(request);
    }
}