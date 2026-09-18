using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.WebAPI.Controllers
{
    using HRMS.Models.ModelClasses;
    using HRMS.WebAPI.Repositories;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class TransportMasterController : ControllerBase
    {
        private readonly IVehicleTypeRepository _vehicleType;
        private readonly IVehicleRepository _vehicle;
        private readonly IPickupPointRepository _pickupPoint;
        private readonly IDriverRepository _driver;

        public TransportMasterController(
            IVehicleTypeRepository vehicleType,
            IVehicleRepository vehicle,
            IPickupPointRepository pickupPoint,
            IDriverRepository driver)
        {
            _vehicleType = vehicleType;
            _vehicle = vehicle;
            _pickupPoint = pickupPoint;
            _driver = driver;
        }

        // ================= VEHICLE TYPE =================

        [HttpGet("vehicle-types")]
        public async Task<IActionResult> GetVehicleTypes()
            => Ok(await _vehicleType.GetVehicleTypes());

        [HttpPost("vehicle-types")]
        public async Task<IActionResult> AddVehicleType(
            VehicleType vehicleType)
            => Ok(await _vehicleType.AddVehicleType(vehicleType));

        [HttpPut("vehicle-types")]
        public async Task<IActionResult> UpdateVehicleType(
            VehicleType vehicleType)
        {
            var result = await _vehicleType.UpdateVehicleType(vehicleType);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("vehicle-types/{id}")]
        public async Task<IActionResult> DeleteVehicleType(int id)
        {
            var result = await _vehicleType.DeleteVehicleType(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= VEHICLE =================

        [HttpGet("vehicles")]
        public async Task<IActionResult> GetVehicles()
            => Ok(await _vehicle.GetVehicles());

        [HttpPost("vehicles")]
        public async Task<IActionResult> AddVehicle(
            Vehicle vehicle)
            => Ok(await _vehicle.AddVehicle(vehicle));

        [HttpPut("vehicles")]
        public async Task<IActionResult> UpdateVehicle(
            Vehicle vehicle)
        {
            var result = await _vehicle.UpdateVehicle(vehicle);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("vehicles/{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var result = await _vehicle.DeleteVehicle(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= PICKUP POINT =================

        [HttpGet("pickup-points")]
        public async Task<IActionResult> GetPickupPoints()
            => Ok(await _pickupPoint.GetPickupPoints());

        [HttpPost("pickup-points")]
        public async Task<IActionResult> AddPickupPoint(
            PickupPoint pickupPoint)
            => Ok(await _pickupPoint.AddPickupPoint(pickupPoint));

        [HttpPut("pickup-points")]
        public async Task<IActionResult> UpdatePickupPoint(
            PickupPoint pickupPoint)
        {
            var result = await _pickupPoint.UpdatePickupPoint(pickupPoint);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("pickup-points/{id}")]
        public async Task<IActionResult> DeletePickupPoint(int id)
        {
            var result = await _pickupPoint.DeletePickupPoint(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= DRIVER =================

        [HttpGet("drivers")]
        public async Task<IActionResult> GetDrivers()
            => Ok(await _driver.GetDrivers());

        [HttpPost("drivers")]
        public async Task<IActionResult> AddDriver(
            Driver driver)
            => Ok(await _driver.AddDriver(driver));

        [HttpPut("drivers")]
        public async Task<IActionResult> UpdateDriver(
            Driver driver)
        {
            var result = await _driver.UpdateDriver(driver);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("drivers/{id}")]
        public async Task<IActionResult> DeleteDriver(int id)
        {
            var result = await _driver.DeleteDriver(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }
    }
}
