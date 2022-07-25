using System.Reflection.Metadata.Ecma335;

namespace Add.Application.Wrappers;

public class PagedResponse<T>: ServiceResponse<T>
{
    private int PageNumber { get; set; }
    private int PageSize { get; set; }

    public PagedResponse()
    {
        PageNumber = 1;
        PageSize = 10;
    }
    public PagedResponse(T value,int pageNumber, int pageSize): base(value)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}