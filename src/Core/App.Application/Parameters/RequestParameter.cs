namespace Add.Application.Parameters;

public class RequestParameter
{
    public RequestParameter(int pageNumber)
    {
        PageNumber = pageNumber;
    }

    public int PageSize { get; set; }
    private int PageNumber { get; set; }
}