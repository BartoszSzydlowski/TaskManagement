namespace TaskManagement.Application.Common.Responses
{
    public class PagedResponse<T> : BaseResponse
    {
        public IEnumerable<T> Data { get; set; } = [];
        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 10;
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
        public bool HasNextPage => PageNumber < TotalPages;
        public bool HasPreviousPage => PageNumber > 1 && TotalPages > 1;
    }
}
