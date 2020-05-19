using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Category;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Category;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;


namespace Banana_E_Commerce_API.Controllers.V1
{
    // [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.Customer)]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IUriService _uriService;

        public CategoryController(
            ICategoryService categoryService,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IUriService uriService
        )
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _appSettings = appSettings;
            _uriService = uriService;
        }

        [AuthorizeRoles(RoleNameEnum.Admin)]
        [HttpPost(ApiRoutes.Category.Create)]
        public async Task<IActionResult> Create([FromBody] CreateCategoryRequest model)
        {
            var createdCategoryUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var categoryEntity = _mapper.Map<Category>(model);

            var isCreateCategorySuccess = await _categoryService.CreateAsync(categoryEntity, createdCategoryUserId);

            if (!isCreateCategorySuccess)
            {
                return BadRequest(
                    new CreateCategoryFailResponse
                    {
                        Errors = new[] { "Create category failed, please try again" }
                    });
            }

            var categoryLocationUri = _uriService.GetByIdUri(
                ApiRoutes.Category.GetById.Replace("{categoryId}", categoryEntity.Id.ToString()));

            var categoryResponse = _mapper.Map<CategoryResponse>(categoryEntity);
            return Created(
                categoryLocationUri,
                new Response<CategoryResponse>(categoryResponse));
        }

        [AuthorizeRoles(RoleNameEnum.Admin)]
        [HttpPut(ApiRoutes.Category.Update)]
        public async Task<IActionResult> Update([FromRoute] int categoryId, [FromBody] UpdateCategoryRequest updateModel)
        {
            var categoryEntity = await _categoryService.GetByIdAsync(categoryId);

            if (categoryEntity == null)
            {
                return NotFound();
            }

            // map modified fields from request model to entity
            _mapper.Map<UpdateCategoryRequest, Category>(updateModel, categoryEntity);

            var isCategoryUpdated = await _categoryService.UpdateAsync(categoryEntity);

            var categoryResponse = _mapper.Map<CategoryResponse>(categoryEntity);
            if (isCategoryUpdated)
            {
                return Ok(new Response<CategoryResponse>(categoryResponse));
            }

            return NotFound();
        }

        [HttpGet(ApiRoutes.Category.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int categoryId)
        {
            var result = await _categoryService.GetByIdAsync(categoryId);
            var categoryResponse = _mapper.Map<CategoryResponse>(result);

            if (result != null)
            {
                return Ok(new Response<CategoryResponse>(categoryResponse));
            }

            return NotFound();
        }

        [HttpGet(ApiRoutes.Category.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllCategoriesQuery filterModel,
            [FromQuery] PaginationQuery paginModel)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllCategoriesFilter>(filterModel);
            var categories = await _categoryService.GetAllAsync(pagination, filter);
            int totalCategories = await _categoryService.CountAllAsync();
            var responseCategories = _mapper.Map<List<CategoryResponse>>(categories);

            var paginationCategoriesResponse = PaginationHelpers.CreatePaginatedResponse(
                _uriService,
                pagination,
                responseCategories,
                totalCategories,
                ApiRoutes.Category.GetAll
            );

            return Ok(paginationCategoriesResponse);
        }
    }
}