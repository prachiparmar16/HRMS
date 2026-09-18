using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.WebAPI.Controllers
{
    using HRMS.Models.ModelClasses;
    using HRMS.WebAPI.Repositories;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ITAssetMasterController : ControllerBase
    {
        private readonly IAssetTypeRepository _assetType;
        private readonly IAssetCategoryRepository _assetCategory;
        private readonly IAssetBrandRepository _assetBrand;
        private readonly IAssetStatusRepository _assetStatus;
        private readonly IHardwareTypeRepository _hardwareType;
        private readonly ISoftwareTypeRepository _softwareType;

        public ITAssetMasterController(
            IAssetTypeRepository assetType,
            IAssetCategoryRepository assetCategory,
            IAssetBrandRepository assetBrand,
            IAssetStatusRepository assetStatus,
            IHardwareTypeRepository hardwareType,
            ISoftwareTypeRepository softwareType)
        {
            _assetType = assetType;
            _assetCategory = assetCategory;
            _assetBrand = assetBrand;
            _assetStatus = assetStatus;
            _hardwareType = hardwareType;
            _softwareType = softwareType;
        }

        // ================= ASSET TYPE =================

        [HttpGet("asset-types")]
        public async Task<IActionResult> GetAssetTypes()
            => Ok(await _assetType.GetAssetTypes());

        [HttpPost("asset-types")]
        public async Task<IActionResult> AddAssetType(AssetType assetType)
            => Ok(await _assetType.AddAssetType(assetType));

        [HttpPut("asset-types")]
        public async Task<IActionResult> UpdateAssetType(AssetType assetType)
        {
            var result = await _assetType.UpdateAssetType(assetType);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("asset-types/{id}")]
        public async Task<IActionResult> DeleteAssetType(int id)
        {
            var result = await _assetType.DeleteAssetType(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= ASSET CATEGORY =================

        [HttpGet("asset-categories")]
        public async Task<IActionResult> GetAssetCategories()
            => Ok(await _assetCategory.GetAssetCategories());

        [HttpPost("asset-categories")]
        public async Task<IActionResult> AddAssetCategory(
            AssetCategory assetCategory)
            => Ok(await _assetCategory.AddAssetCategory(assetCategory));

        [HttpPut("asset-categories")]
        public async Task<IActionResult> UpdateAssetCategory(
            AssetCategory assetCategory)
        {
            var result =
                await _assetCategory.UpdateAssetCategory(assetCategory);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("asset-categories/{id}")]
        public async Task<IActionResult> DeleteAssetCategory(int id)
        {
            var result =
                await _assetCategory.DeleteAssetCategory(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= ASSET BRAND =================

        [HttpGet("asset-brands")]
        public async Task<IActionResult> GetAssetBrands()
            => Ok(await _assetBrand.GetAssetBrands());

        [HttpPost("asset-brands")]
        public async Task<IActionResult> AddAssetBrand(AssetBrand assetBrand)
            => Ok(await _assetBrand.AddAssetBrand(assetBrand));

        [HttpPut("asset-brands")]
        public async Task<IActionResult> UpdateAssetBrand(
            AssetBrand assetBrand)
        {
            var result =
                await _assetBrand.UpdateAssetBrand(assetBrand);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("asset-brands/{id}")]
        public async Task<IActionResult> DeleteAssetBrand(int id)
        {
            var result =
                await _assetBrand.DeleteAssetBrand(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= ASSET STATUS =================

        [HttpGet("asset-statuses")]
        public async Task<IActionResult> GetAssetStatuses()
            => Ok(await _assetStatus.GetAssetStatuses());

        [HttpPost("asset-statuses")]
        public async Task<IActionResult> AddAssetStatus(
            AssetStatus assetStatus)
            => Ok(await _assetStatus.AddAssetStatus(assetStatus));

        [HttpPut("asset-statuses")]
        public async Task<IActionResult> UpdateAssetStatus(
            AssetStatus assetStatus)
        {
            var result =
                await _assetStatus.UpdateAssetStatus(assetStatus);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("asset-statuses/{id}")]
        public async Task<IActionResult> DeleteAssetStatus(int id)
        {
            var result =
                await _assetStatus.DeleteAssetStatus(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= HARDWARE TYPE =================

        [HttpGet("hardware-types")]
        public async Task<IActionResult> GetHardwareTypes()
            => Ok(await _hardwareType.GetHardwareTypes());

        [HttpPost("hardware-types")]
        public async Task<IActionResult> AddHardwareType(
            HardwareType hardwareType)
            => Ok(await _hardwareType.AddHardwareType(hardwareType));

        [HttpPut("hardware-types")]
        public async Task<IActionResult> UpdateHardwareType(
            HardwareType hardwareType)
        {
            var result =
                await _hardwareType.UpdateHardwareType(hardwareType);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("hardware-types/{id}")]
        public async Task<IActionResult> DeleteHardwareType(int id)
        {
            var result =
                await _hardwareType.DeleteHardwareType(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= SOFTWARE TYPE =================

        [HttpGet("software-types")]
        public async Task<IActionResult> GetSoftwareTypes()
            => Ok(await _softwareType.GetSoftwareTypes());

        [HttpPost("software-types")]
        public async Task<IActionResult> AddSoftwareType(
            SoftwareType softwareType)
            => Ok(await _softwareType.AddSoftwareType(softwareType));

        [HttpPut("software-types")]
        public async Task<IActionResult> UpdateSoftwareType(
            SoftwareType softwareType)
        {
            var result =
                await _softwareType.UpdateSoftwareType(softwareType);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("software-types/{id}")]
        public async Task<IActionResult> DeleteSoftwareType(int id)
        {
            var result =
                await _softwareType.DeleteSoftwareType(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }
    }
}
