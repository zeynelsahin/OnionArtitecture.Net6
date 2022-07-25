namespace Add.Application.Wrappers;

public class ServiceResponse<T>
{
    public ServiceResponse(T value)
    {
        Value = value;
    }

    protected ServiceResponse()
    {
        
    }
    public T Value { get; set; }
}