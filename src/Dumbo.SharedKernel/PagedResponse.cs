using System;

namespace Dumbo.SharedKernel;

public class PagedResponse<T>
{
    public Pagination Pagination { get; }
    public List<T> Data { get; }

    public PagedResponse(List<T> data, Pagination pagination)
    {
        Data = data;
        Pagination = pagination;
    }
}
