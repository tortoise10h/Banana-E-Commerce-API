using System;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Entities;
using Microsoft.AspNetCore.WebUtilities;

namespace Banana_E_Commerce_API.Services
{
    public interface IUriService
    {
        Uri GetByIdUri(string getByIdApiPath);
        Uri GetAllUri(string getAllApiPath, PaginationQuery pagination = null);

    }

    public class UriService : IUriService
    {
        private readonly string _baseUri;

        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetAllUri(string getAllApiPath, PaginationQuery pagination = null)
        {
            var uri = new Uri(_baseUri);

            if (pagination == null)
            {
                return uri;
            }

            string getAllUrl = _baseUri + getAllApiPath;
            var modifiedUri = QueryHelpers.AddQueryString(getAllUrl, "pageNumber", pagination.PageNumber.ToString());
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", pagination.PageSize.ToString());

            return new Uri(modifiedUri);
        }

        public Uri GetByIdUri(string getByIdApiPath)
        {
            return new Uri(_baseUri + getByIdApiPath);
        }
    }
}