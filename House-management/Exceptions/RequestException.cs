namespace House_management.Exceptions;

public class RequestException : Exception
{
    public RequestException(string message) : base(message) { }
}