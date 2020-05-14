namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries
{
    public class PaginationQuery
    {
        private int _pageNumber;
        private int _pageSize;

        private const int PAGE_SIZE_DEFAULT = 10;
        private const int PAGE_NUMBER_DEFAULT = 1;

        public PaginationQuery()
        {
            _pageNumber = PAGE_NUMBER_DEFAULT;
            _pageSize = PAGE_SIZE_DEFAULT;
        }
        public PaginationQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber > 0 ? pageNumber : PAGE_NUMBER_DEFAULT;
            PageSize = pageSize > 0 ? pageSize : PAGE_SIZE_DEFAULT;
        }

        public int PageNumber
        {
            get
            {
                return _pageNumber;
            }
            set
            {
                _pageNumber = value > 0 ? value : PAGE_NUMBER_DEFAULT;
            }
        }
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value > 0 ? value : PAGE_SIZE_DEFAULT;
            }
        }
    }
}