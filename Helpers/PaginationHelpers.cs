using System;
using System.Collections.Generic;
using System.Linq;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Category;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Services;

namespace Banana_E_Commerce_API.Helpers
{
    public class PaginationHelpers
    {
        internal static PagedResponse<T> CreatePaginatedResponse<T>(
            IUriService uriService,
            PaginationFilter paginationFilter,
            List<T> response,
            int total,
            string getAllApiPath)
        {
            var nextPage = paginationFilter.PageNumber >= 1
                ? uriService
                    .GetAllUri(
                        getAllApiPath,
                        new PaginationQuery(
                            paginationFilter.PageNumber + 1, paginationFilter.PageSize)).ToString()
                : null;

            var previousPage = paginationFilter.PageNumber - 1 >= 1
                ? uriService
                    .GetAllUri(
                        getAllApiPath,
                        new PaginationQuery(
                            paginationFilter.PageNumber - 1, paginationFilter.PageSize)).ToString()
                : null;

            int totalPage = (int)Math.Ceiling((double)total / paginationFilter.PageSize);

            return new PagedResponse<T>
            {
                Data = response,
                PageNumber = paginationFilter.PageNumber >= 1 ? paginationFilter.PageNumber : (int?)null,
                PageSize = paginationFilter.PageSize >= 1 ? paginationFilter.PageSize : (int?)null,
                // calculate that we have next page or not
                NextPage = response.LongCount() < paginationFilter.PageSize
                    ? null
                    : (paginationFilter.PageNumber * paginationFilter.PageSize < total
                        ? nextPage
                        : null),
                PreviousPage = previousPage,
                TotalPage = totalPage == 0 ? 1 : totalPage
            };
        }
    }
}