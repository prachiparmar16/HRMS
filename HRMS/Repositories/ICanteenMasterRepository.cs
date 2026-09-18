using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ICanteenMasterRepository
    {
        // =========================
        // FOOD CATEGORY
        // =========================

        Task<List<FoodCategory>> GetFoodCategories();
        Task<FoodCategory?> GetFoodCategoryById(int foodCategoryId);
        Task<FoodCategory> AddFoodCategory(FoodCategory foodCategory);
        Task<FoodCategory?> UpdateFoodCategory(FoodCategory foodCategory);
        Task<bool> DeleteFoodCategory(int foodCategoryId);


        // =========================
        // FOOD ITEM
        // =========================

        Task<List<FoodItem>> GetFoodItems();
        Task<FoodItem?> GetFoodItemById(int foodItemId);
        Task<FoodItem> AddFoodItem(FoodItem foodItem);
        Task<FoodItem?> UpdateFoodItem(FoodItem foodItem);
        Task<bool> DeleteFoodItem(int foodItemId);


        // =========================
        // MEAL TYPE
        // =========================

        Task<List<MealType>> GetMealTypes();
        Task<MealType?> GetMealTypeById(int mealTypeId);
        Task<MealType> AddMealType(MealType mealType);
        Task<MealType?> UpdateMealType(MealType mealType);
        Task<bool> DeleteMealType(int mealTypeId);


        // =========================
        // CANTEEN
        // =========================

        Task<List<Canteen>> GetCanteens();
        Task<Canteen?> GetCanteenById(int canteenId);
        Task<Canteen> AddCanteen(Canteen canteen);
        Task<Canteen?> UpdateCanteen(Canteen canteen);
        Task<bool> DeleteCanteen(int canteenId);


        // =========================
        // MEAL PLAN
        // =========================

        Task<List<MealPlan>> GetMealPlans();
        Task<MealPlan?> GetMealPlanById(int mealPlanId);
        Task<MealPlan> AddMealPlan(MealPlan mealPlan);
        Task<MealPlan?> UpdateMealPlan(MealPlan mealPlan);
        Task<bool> DeleteMealPlan(int mealPlanId);
    }
}