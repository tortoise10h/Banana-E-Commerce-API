using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Storage;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Storage;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Controllers.V1
{
    [AuthorizeRoles(RoleNameEnum.Admin)]
    public class StorageController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IStorageService _storageService;
        private readonly IUriService _uriService;
        private readonly IMapper _mapper;

        public StorageController(
            IStorageService storageservice,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _storageService = storageservice;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
        }

        [HttpPost(ApiRoutes.Storage.Create)]
        public async Task<IActionResult> Create([FromBody] CreateStorageRequest createModel)
        {
            var storageEntity = _mapper.Map<Storage>(createModel);
            var createdUserId = int.Parse(HttpContext.GetUserIdFromRequest());

            var isCreateSuccess = await _storageService.CreateAsync(storageEntity, createdUserId);

            if (!isCreateSuccess)
            {
                return BadRequest("Tạo kho hàng không thành công, vui lòng thử lại");
            }

            var storageUri = _uriService.GetByIdUri(
                            ApiRoutes.Storage.GetById.Replace("{storageId}", storageEntity.Id.ToString()));
            var storageResponse = _mapper.Map<StorageResponse>(storageEntity);
            return Created(
                storageUri,
                new Response<StorageResponse>(storageResponse));
        }

        [HttpGet(ApiRoutes.Storage.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int storageId)
        {
            var result = await _storageService.GetByIdAsync(storageId);
            var storageResponse = _mapper.Map<StorageResponse>(result);

            if (result != null)
            {
                return Ok(new Response<StorageResponse>(storageResponse));
            }
            return NotFound();
        }

        [HttpPut(ApiRoutes.Storage.Update)]
        public async Task<IActionResult> Update([FromRoute] int storageId, [FromBody] UpdateStorageRequest updateModel)
        {
            var storageEntity = await _storageService.GetByIdAsync(storageId);

            if (storageEntity == null)
            {
                return NotFound();
            }

            // map modified fields from request model to entity
            _mapper.Map<UpdateStorageRequest, Storage>(updateModel, storageEntity);

            var isStorageUpdated = await _storageService.UpdateAsync(storageEntity);

            var storageResponse = _mapper.Map<StorageResponse>(storageEntity);
            if (isStorageUpdated)
            {
                return Ok(new Response<StorageResponse>(storageResponse));
            }

            return NotFound();
        }
    }
}