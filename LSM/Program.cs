using AutoMapper;
using LSM.Dto;
using LSM.Entities;
using LSM.Exceptions;
using LSM.Mapping;
using LSM.Services.Application.Sorting;
using LSM.Services.Data;
using LSM.Services.Domain;
using LSM.Services.Domain.Groups;
using LSM.Services.Domain.Locks;
using LSM.Services.Filter;
using LSM.Services.Locks;
using LSM.Services.Sorting;
using LSM.Services.Weight;

namespace LSM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
            {
                builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
            }));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<IDataService, DataService>();

            builder.Services.AddScoped<IWeightService, WeightService>();
            builder.Services.AddScoped<ISortService<IWeighted>, SortService>();

            builder.Services.AddScoped<IFilterService<Lock>, FilterLockService>();
            builder.Services.AddScoped<ISearchService<LockDto>, LockSearchService>();

            builder.Services.AddScoped<IFilterService<Building>, FilterBuildingService>();
            builder.Services.AddScoped<ISearchService<BuildingDto>, BuildingSearchService>();

            builder.Services.AddScoped<IFilterService<Group>, FilterGroupService>();
            builder.Services.AddScoped<ISearchService<GroupDto>, GroupSearchService>();

            builder.Services.AddScoped<IFilterService<Medium>, FilterMediaService>();
            builder.Services.AddScoped<ISearchService<MediaDto>, MediaSearchService>();

            //builder.Services.AddAutoMapper(typeof(Program));
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            builder.Services.AddSingleton(mapper);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseMiddleware<ErrorHandlerMiddleware>();

            app.UseCors("corsapp");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}