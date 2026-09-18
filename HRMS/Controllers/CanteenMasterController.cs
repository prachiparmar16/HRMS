using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CanteenMasterController : ControllerBase
    {
        private readonly ICanteenMasterRepository _service;

        public CanteenMasterController(ICanteenMasterRepository service)
        {
            _service = service;
        }

        // ==================== FOOD CATEGORY ====================

        [HttpGet("food-categories")]
        public async Task<IActionResult> GetFoodCategories()
        {
            return Ok(await _service.GetFoodCategories());
        }

        [HttpGet("food-category/{id}")]
        public async Task<IActionResult> GetFoodCategoryById(int id)
        {
            var foodCategory = await _service.GetFoodCategoryById(id);

            if (foodCategory == null)
                return NotFound("Food Category not found.");

            return Ok(foodCategory);
        }

        [HttpPost("food-category")]
        public async Task<IActionResult> AddFoodCategory(FoodCategory foodCategory)
        {
            var exists = (await _service.GetFoodCategories())
                .Any(x => x.FoodCategoryName.Trim().ToLower()
                    == foodCategory.FoodCategoryName.Trim().ToLower());

            if (exists)
                return Conflict("Food Category already exists.");

            var result = await _service.AddFoodCategory(foodCategory);

            return Ok(result);
        }

        [HttpPut("food-category/{id}")]
        public async Task<IActionResult> UpdateFoodCategory(
            int id,
            FoodCategory foodCategory)
        {
            var existing = await _service.GetFoodCategoryById(id);

            if (existing == null)
                return NotFound("Food Category not found.");

            var duplicate = (await _service.GetFoodCategories())
                .Any(x => x.FoodCategoryId != id &&
                         x.FoodCategoryName.Trim().ToLower()
                            == foodCategory.FoodCategoryName.Trim().ToLower());

            if (duplicate)
                return Conflict("Food Category already exists.");

            existing.FoodCategoryName = foodCategory.FoodCategoryName;
            existing.IsActive = foodCategory.IsActive;

            var result = await _service.UpdateFoodCategory(existing);

            return Ok(result);
        }

        [HttpDelete("food-category/{id}")]
        public async Task<IActionResult> DeleteFoodCategory(int id)
        {
            var existing = await _service.GetFoodCategoryById(id);

            if (existing == null)
                return NotFound("Food Category not found.");

            await _service.DeleteFoodCategory(id);

            return Ok("Food Category deleted successfully.");
        }


        // ==================== FOOD ITEM ====================

        [HttpGet("food-items")]
        public async Task<IActionResult> GetFoodItems()
        {
            return Ok(await _service.GetFoodItems());
        }

        [HttpGet("food-item/{id}")]
        public async Task<IActionResult> GetFoodItemById(int id)
        {
            var foodItem = await _service.GetFoodItemById(id);

            if (foodItem == null)
                return NotFound("Food Item not found.");

            return Ok(foodItem);
        }

        [HttpPost("food-item")]
        public async Task<IActionResult> AddFoodItem(FoodItem foodItem)
        {
            var exists = (await _service.GetFoodItems())
                .Any(x => x.FoodItemName.Trim().ToLower()
                            == foodItem.FoodItemName.Trim().ToLower()
                       && x.FoodCategoryId == foodItem.FoodCategoryId);

            if (exists)
                return Conflict("Food Item already exists in this category.");

            var result = await _service.AddFoodItem(foodItem);

            return Ok(result);
        }

        [HttpPut("food-item/{id}")]
        public async Task<IActionResult> UpdateFoodItem(
            int id,
            FoodItem foodItem)
        {
            var existing = await _service.GetFoodItemById(id);

            if (existing == null)
                return NotFound("Food Item not found.");

            var duplicate = (await _service.GetFoodItems())
                .Any(x => x.FoodItemId != id &&
                         x.FoodItemName.Trim().ToLower()
                            == foodItem.FoodItemName.Trim().ToLower()
                         && x.FoodCategoryId == foodItem.FoodCategoryId);

            if (duplicate)
                return Conflict("Food Item already exists in this category.");

            existing.FoodItemName = foodItem.FoodItemName;
            existing.FoodCategoryId = foodItem.FoodCategoryId;
            existing.IsActive = foodItem.IsActive;

            var result = await _service.UpdateFoodItem(existing);

            return Ok(result);
        }

        [HttpDelete("food-item/{id}")]
        public async Task<IActionResult> DeleteFoodItem(int id)
        {
            var existing = await _service.GetFoodItemById(id);

            if (existing == null)
                return NotFound("Food Item not found.");

            await _service.DeleteFoodItem(id);

            return Ok("Food Item deleted successfully.");
        }


        // ==================== MEAL TYPE ====================

        [HttpGet("meal-types")]
        public async Task<IActionResult> GetMealTypes()
        {
            return Ok(await _service.GetMealTypes());
        }

        [HttpGet("meal-type/{id}")]
        public async Task<IActionResult> GetMealTypeById(int id)
        {
            var mealType = await _service.GetMealTypeById(id);

            if (mealType == null)
                return NotFound("Meal Type not found.");

            return Ok(mealType);
        }

        [HttpPost("meal-type")]
        public async Task<IActionResult> AddMealType(MealType mealType)
        {
            var exists = (await _service.GetMealTypes())
                .Any(x => x.MealTypeName.Trim().ToLower()
                    == mealType.MealTypeName.Trim().ToLower());

            if (exists)
                return Conflict("Meal Type already exists.");

            var result = await _service.AddMealType(mealType);

            return Ok(result);
        }

        [HttpPut("meal-type/{id}")]
        public async Task<IActionResult> UpdateMealType(
            int id,
            MealType mealType)
        {
            var existing = await _service.GetMealTypeById(id);

            if (existing == null)
                return NotFound("Meal Type not found.");

            var duplicate = (await _service.GetMealTypes())
                .Any(x => x.MealTypeId != id &&
                         x.MealTypeName.Trim().ToLower()
                            == mealType.MealTypeName.Trim().ToLower());

            if (duplicate)
                return Conflict("Meal Type already exists.");

            existing.MealTypeName = mealType.MealTypeName;
            existing.IsActive = mealType.IsActive;

            var result = await _service.UpdateMealType(existing);

            return Ok(result);
        }

        [HttpDelete("meal-type/{id}")]
        public async Task<IActionResult> DeleteMealType(int id)
        {
            var existing = await _service.GetMealTypeById(id);

            if (existing == null)
                return NotFound("Meal Type not found.");

            await _service.DeleteMealType(id);

            return Ok("Meal Type deleted successfully.");
        }


        // ==================== CANTEEN ====================

        [HttpGet("canteens")]
        public async Task<IActionResult> GetCanteens()
        {
            return Ok(await _service.GetCanteens());
        }

        [HttpGet("canteen/{id}")]
        public async Task<IActionResult> GetCanteenById(int id)
        {
            var canteen = await _service.GetCanteenById(id);

            if (canteen == null)
                return NotFound("Canteen not found.");

            return Ok(canteen);
        }

        [HttpPost("canteen")]
        public async Task<IActionResult> AddCanteen(Canteen canteen)
        {
            var exists = (await _service.GetCanteens())
                .Any(x => x.CanteenName.Trim().ToLower()
                    == canteen.CanteenName.Trim().ToLower());

            if (exists)
                return Conflict("Canteen already exists.");

            var result = await _service.AddCanteen(canteen);

            return Ok(result);
        }

        [HttpPut("canteen/{id}")]
        public async Task<IActionResult> UpdateCanteen(
            int id,
            Canteen canteen)
        {
            var existing = await _service.GetCanteenById(id);

            if (existing == null)
                return NotFound("Canteen not found.");

            var duplicate = (await _service.GetCanteens())
                .Any(x => x.CanteenId != id &&
                         x.CanteenName.Trim().ToLower()
                            == canteen.CanteenName.Trim().ToLower());

            if (duplicate)
                return Conflict("Canteen already exists.");

            existing.CanteenName = canteen.CanteenName;
            existing.Location = canteen.Location;
            existing.IsActive = canteen.IsActive;

            var result = await _service.UpdateCanteen(existing);

            return Ok(result);
        }

        [HttpDelete("canteen/{id}")]
        public async Task<IActionResult> DeleteCanteen(int id)
        {
            var existing = await _service.GetCanteenById(id);

            if (existing == null)
                return NotFound("Canteen not found.");

            await _service.DeleteCanteen(id);

            return Ok("Canteen deleted successfully.");
        }


        // ==================== MEAL PLAN ====================

        [HttpGet("meal-plans")]
        public async Task<IActionResult> GetMealPlans()
        {
            return Ok(await _service.GetMealPlans());
        }

        [HttpGet("meal-plan/{id}")]
        public async Task<IActionResult> GetMealPlanById(int id)
        {
            var mealPlan = await _service.GetMealPlanById(id);

            if (mealPlan == null)
                return NotFound("Meal Plan not found.");

            return Ok(mealPlan);
        }

        [HttpPost("meal-plan")]
        public async Task<IActionResult> AddMealPlan(MealPlan mealPlan)
        {
            var exists = (await _service.GetMealPlans())
                .Any(x => x.MealPlanName.Trim().ToLower()
                    == mealPlan.MealPlanName.Trim().ToLower());

            if (exists)
                return Conflict("Meal Plan already exists.");

            var result = await _service.AddMealPlan(mealPlan);

            return Ok(result);
        }

        [HttpPut("meal-plan/{id}")]
        public async Task<IActionResult> UpdateMealPlan(
            int id,
            MealPlan mealPlan)
        {
            var existing = await _service.GetMealPlanById(id);

            if (existing == null)
                return NotFound("Meal Plan not found.");

            var duplicate = (await _service.GetMealPlans())
                .Any(x => x.MealPlanId != id &&
                         x.MealPlanName.Trim().ToLower()
                            == mealPlan.MealPlanName.Trim().ToLower());

            if (duplicate)
                return Conflict("Meal Plan already exists.");

            existing.MealPlanName = mealPlan.MealPlanName;
            existing.MealTypeId = mealPlan.MealTypeId;
            existing.IsActive = mealPlan.IsActive;

            var result = await _service.UpdateMealPlan(existing);

            return Ok(result);
        }

        [HttpDelete("meal-plan/{id}")]
        public async Task<IActionResult> DeleteMealPlan(int id)
        {
            var existing = await _service.GetMealPlanById(id);

            if (existing == null)
                return NotFound("Meal Plan not found.");

            await _service.DeleteMealPlan(id);

            return Ok("Meal Plan deleted successfully.");
        }
    }
}