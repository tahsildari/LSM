using LSM.Dto;
using LSM.Entities;
using LSM.Services.Application.Sorting;
using LSM.Services.Data;
using LSM.Services.Domain;
using LSM.Services.Domain.Groups;
using LSM.Services.Domain.Locks;
using LSM.Services.Filter;
using LSM.Services.Locks;
using LSM.Services.Sorting;
using LSM.Services.Weight;

namespace LSM.Extensions
{
    public static class AppServicesExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IDataService, DataService>();

            services.AddScoped<IWeightService, WeightService>();
            services.AddScoped<ISortService<IWeighted>, SortService>();

            services.AddScoped<IFilterService<Lock>, FilterLockService>();
            services.AddScoped<ISearchService<LockDto>, LockSearchService>();

            services.AddScoped<IFilterService<Building>, FilterBuildingService>();
            services.AddScoped<ISearchService<BuildingDto>, BuildingSearchService>();

            services.AddScoped<IFilterService<Group>, FilterGroupService>();
            services.AddScoped<ISearchService<GroupDto>, GroupSearchService>();

            services.AddScoped<IFilterService<Medium>, FilterMediaService>();
            services.AddScoped<ISearchService<MediaDto>, MediaSearchService>();
        }
    }
}
