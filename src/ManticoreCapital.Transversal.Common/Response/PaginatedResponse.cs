namespace ManticoreCapital.Transversal.Common.Response
{
    public class PaginatedResponse<T>
    {
        public IEnumerable<T> Results { get; }
        public int TotalItemCount { get; }
        public int ItemsPerPage { get; }
        public int CurrentPage { get; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItemCount / ItemsPerPage);
        public bool HasNextPage => CurrentPage < TotalPages;
        public bool HasPreviousPage => CurrentPage > 1;

        public PaginatedResponse(IEnumerable<T> results, int totalItemCount, int currentPage, int itemsPerPage)
        {
            if (results == null) throw new ArgumentNullException(nameof(results));
            if (totalItemCount < 0) throw new ArgumentOutOfRangeException(nameof(totalItemCount));
            if (currentPage < 1) throw new ArgumentOutOfRangeException($"currentPage {currentPage}");
            if (itemsPerPage < 1) throw new ArgumentOutOfRangeException(nameof(itemsPerPage));

            Results = results;
            TotalItemCount = totalItemCount;
            CurrentPage = currentPage;
            ItemsPerPage = itemsPerPage;
        }
    }
}
