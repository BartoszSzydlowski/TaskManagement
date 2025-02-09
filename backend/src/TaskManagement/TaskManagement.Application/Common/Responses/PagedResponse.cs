namespace TaskManagement.Application.Common.Responses
{
    public class PagedResponse<T>(IEnumerable<T> data, int totalCount, int pageNumber, int pageSize = 10) : BaseResponse
    {
        public IEnumerable<T> Data { get; set; } = data;
        public int PageNumber { get; set; } = pageNumber;
        public int PageSize { get; set; } = pageSize > 0 ? pageSize : 10;
        public int TotalCount { get; set; } = totalCount;
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
        public bool HasNextPage => PageNumber < TotalPages;
        public bool HasPreviousPage => PageNumber > 1;
    }
}
