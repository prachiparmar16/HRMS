using FluentValidation;
using FluentValidation.AspNetCore;
using HRMS.Database.Validators;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using HRMS.WebAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<HrmsDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("HrmsCS")));
builder.Services.AddValidatorsFromAssemblyContaining<UserLoginValidator>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeService>();
builder.Services.AddScoped<ILeaveRepository, LeaveService>();
// Common HRMS Master Services
builder.Services.AddScoped<ICountryRepository, CountryService>();
builder.Services.AddScoped<IStateRepository, StateService>();
builder.Services.AddScoped<ICityRepository, CityService>();
builder.Services.AddScoped<ICurrencyRepository, CurrencyService>();
builder.Services.AddScoped<ILanguageRepository, LanguageService>();
builder.Services.AddScoped<IGenderRepository, GenderService>();
builder.Services.AddScoped<IBloodGroupRepository, BloodGroupService>();
builder.Services.AddScoped<IMaritalStatusRepository, MaritalStatusService>();
builder.Services.AddScoped<IDocumentTypeRepository, DocumentTypeService>();
builder.Services.AddScoped<IRelationshipTypeRepository, RelationshipTypeService>();
// Transport Master Services
builder.Services.AddScoped<IVehicleTypeRepository, VehicleTypeService>();
builder.Services.AddScoped<IVehicleRepository, VehicleService>();
builder.Services.AddScoped<IPickupPointRepository, PickupPointService>();
builder.Services.AddScoped<IDriverRepository, DriverService>();
// IT / Asset Master Services
builder.Services.AddScoped<IAssetTypeRepository, AssetTypeService>();
builder.Services.AddScoped<IAssetCategoryRepository, AssetCategoryService>();
builder.Services.AddScoped<IAssetBrandRepository, AssetBrandService>();
builder.Services.AddScoped<IAssetStatusRepository, AssetStatusService>();
builder.Services.AddScoped<IHardwareTypeRepository, HardwareTypeService>();
builder.Services.AddScoped<ISoftwareTypeRepository, SoftwareTypeService>();
// Payroll Master Services
builder.Services.AddScoped<ISalaryComponentRepository, SalaryComponentService>();
builder.Services.AddScoped<IAllowanceTypeRepository, AllowanceTypeService>();
builder.Services.AddScoped<IDeductionTypeRepository, DeductionTypeService>();
builder.Services.AddScoped<IPayFrequencyRepository, PayFrequencyService>();
builder.Services.AddScoped<ISalaryGradeRepository, SalaryGradeService>();
builder.Services.AddScoped<ITaxSlabRepository, TaxSlabService>();
builder.Services.AddScoped<IPayrollPolicyRepository, PayrollPolicyService>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
