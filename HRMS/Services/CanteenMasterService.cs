using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class CanteenMasterService : ICanteenMasterRepository
    {
        private readonly HrmsDbContext _db;

        public CanteenMasterService(HrmsDbContext db)
        {
            _db = db;
        }

        // =========================
        // FOOD CATEGORY
        // =========================

        public async Task<List<FoodCategory>> GetFoodCategories()
        {
            return await _db.FoodCategorystbl
                .ToListAsync();
        }

        public async Task<FoodCategory?> GetFoodCategoryById(
            int foodCategoryId)
        {
            return await _db.FoodCategorystbl
                .FirstOrDefaultAsync(x =>
                    x.FoodCategoryId == foodCategoryId);
        }

        public async Task<FoodCategory> AddFoodCategory(
            FoodCategory foodCategory)
        {
            _db.FoodCategorystbl.Add(foodCategory);
            await _db.SaveChangesAsync();

            return foodCategory;
        }

        public async Task<FoodCategory?> UpdateFoodCategory(
            FoodCategory foodCategory)
        {
            var existingFoodCategory =
                await _db.FoodCategorystbl
                .FirstOrDefaultAsync(x =>
                    x.FoodCategoryId == foodCategory.FoodCategoryId);

            if (existingFoodCategory == null)
                return null;

            existingFoodCategory.FoodCategoryName =
                foodCategory.FoodCategoryName;

            existingFoodCategory.IsActive =
                foodCategory.IsActive;

            await _db.SaveChangesAsync();

            return existingFoodCategory;
        }

        public async Task<bool> DeleteFoodCategory(
            int foodCategoryId)
        {
            var foodCategory =
                await _db.FoodCategorystbl
                .FirstOrDefaultAsync(x =>
                    x.FoodCategoryId == foodCategoryId);

            if (foodCategory == null)
                return false;

            _db.FoodCategorystbl.Remove(foodCategory);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // FOOD ITEM
        // =========================

        public async Task<List<FoodItem>> GetFoodItems()
        {
            return await _db.FoodItemstbl
                .Include(x => x.FoodCategory)
                .ToListAsync();
        }

        public async Task<FoodItem?> GetFoodItemById(int foodItemId)
        {
            return await _db.FoodItemstbl
                .Include(x => x.FoodCategory)
                .FirstOrDefaultAsync(x =>
                    x.FoodItemId == foodItemId);
        }

        public async Task<FoodItem> AddFoodItem(FoodItem foodItem)
        {
            _db.FoodItemstbl.Add(foodItem);
            await _db.SaveChangesAsync();

            return foodItem;
        }

        public async Task<FoodItem?> UpdateFoodItem(FoodItem foodItem)
        {
            var existingFoodItem =
                await _db.FoodItemstbl
                .FirstOrDefaultAsync(x =>
                    x.FoodItemId == foodItem.FoodItemId);

            if (existingFoodItem == null)
                return null;

            existingFoodItem.FoodItemName =
                foodItem.FoodItemName;

            existingFoodItem.FoodCategoryId =
                foodItem.FoodCategoryId;

            existingFoodItem.IsActive =
                foodItem.IsActive;

            await _db.SaveChangesAsync();

            return existingFoodItem;
        }

        public async Task<bool> DeleteFoodItem(int foodItemId)
        {
            var foodItem =
                await _db.FoodItemstbl
                .FirstOrDefaultAsync(x =>
                    x.FoodItemId == foodItemId);

            if (foodItem == null)
                return false;

            _db.FoodItemstbl.Remove(foodItem);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // MEAL TYPE
        // =========================

        public async Task<List<MealType>> GetMealTypes()
        {
            return await _db.MealTypestbl
                .ToListAsync();
        }

        public async Task<MealType?> GetMealTypeById(int mealTypeId)
        {
            return await _db.MealTypestbl
                .FirstOrDefaultAsync(x =>
                    x.MealTypeId == mealTypeId);
        }

        public async Task<MealType> AddMealType(MealType mealType)
        {
            _db.MealTypestbl.Add(mealType);
            await _db.SaveChangesAsync();

            return mealType;
        }

        public async Task<MealType?> UpdateMealType(
            MealType mealType)
        {
            var existingMealType =
                await _db.MealTypestbl
                .FirstOrDefaultAsync(x =>
                    x.MealTypeId == mealType.MealTypeId);

            if (existingMealType == null)
                return null;

            existingMealType.MealTypeName =
                mealType.MealTypeName;

            existingMealType.IsActive =
                mealType.IsActive;

            await _db.SaveChangesAsync();

            return existingMealType;
        }

        public async Task<bool> DeleteMealType(int mealTypeId)
        {
            var mealType =
                await _db.MealTypestbl
                .FirstOrDefaultAsync(x =>
                    x.MealTypeId == mealTypeId);

            if (mealType == null)
                return false;

            _db.MealTypestbl.Remove(mealType);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // CANTEEN
        // =========================

        public async Task<List<Canteen>> GetCanteens()
        {
            return await _db.Canteentbl
                .ToListAsync();
        }

        public async Task<Canteen?> GetCanteenById(int canteenId)
        {
            return await _db.Canteentbl
                .FirstOrDefaultAsync(x =>
                    x.CanteenId == canteenId);
        }

        public async Task<Canteen> AddCanteen(Canteen canteen)
        {
            _db.Canteentbl.Add(canteen);
            await _db.SaveChangesAsync();

            return canteen;
        }

        public async Task<Canteen?> UpdateCanteen(Canteen canteen)
        {
            var existingCanteen =
                await _db.Canteentbl
                .FirstOrDefaultAsync(x =>
                    x.CanteenId == canteen.CanteenId);

            if (existingCanteen == null)
                return null;

            existingCanteen.CanteenName =
                canteen.CanteenName;

            existingCanteen.Location =
                canteen.Location;

            existingCanteen.IsActive =
                canteen.IsActive;

            await _db.SaveChangesAsync();

            return existingCanteen;
        }

        public async Task<bool> DeleteCanteen(int canteenId)
        {
            var canteen =
                await _db.Canteentbl
                .FirstOrDefaultAsync(x =>
                    x.CanteenId == canteenId);

            if (canteen == null)
                return false;

            _db.Canteentbl.Remove(canteen);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // MEAL PLAN
        // =========================

        public async Task<List<MealPlan>> GetMealPlans()
        {
            return await _db.MealPlanstbl
                .Include(x => x.MealType)
                .ToListAsync();
        }

        public async Task<MealPlan?> GetMealPlanById(int mealPlanId)
        {
            return await _db.MealPlanstbl
                .Include(x => x.MealType)
                .FirstOrDefaultAsync(x =>
                    x.MealPlanId == mealPlanId);
        }

        public async Task<MealPlan> AddMealPlan(MealPlan mealPlan)
        {
            _db.MealPlanstbl.Add(mealPlan);
            await _db.SaveChangesAsync();

            return mealPlan;
        }

        public async Task<MealPlan?> UpdateMealPlan(
            MealPlan mealPlan)
        {
            var existingMealPlan =
                await _db.MealPlanstbl
                .FirstOrDefaultAsync(x =>
                    x.MealPlanId == mealPlan.MealPlanId);

            if (existingMealPlan == null)
                return null;

            existingMealPlan.MealPlanName =
                mealPlan.MealPlanName;

            existingMealPlan.MealTypeId =
                mealPlan.MealTypeId;

            existingMealPlan.IsActive =
                mealPlan.IsActive;

            await _db.SaveChangesAsync();

            return existingMealPlan;
        }

        public async Task<bool> DeleteMealPlan(int mealPlanId)
        {
            var mealPlan =
                await _db.MealPlanstbl
                .FirstOrDefaultAsync(x =>
                    x.MealPlanId == mealPlanId);

            if (mealPlan == null)
                return false;

            _db.MealPlanstbl.Remove(mealPlan);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}