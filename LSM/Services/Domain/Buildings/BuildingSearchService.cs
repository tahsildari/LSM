using AutoMapper;
using LSM.Dto;
using LSM.Entities;
using LSM.Services.Application.Sorting;
using LSM.Services.Data;
using LSM.Services.Domain;
using LSM.Services.Domain.Locks;
using LSM.Services.Filter;
using LSM.Services.Sorting;
using LSM.Services.Weight;

namespace LSM.Services.Locks
{
    public class BuildingSearchService : ISearchService<BuildingDto>
    {
        private readonly IDataService dataService;
        private readonly IFilterService<Building> filterService;
        private readonly IWeightService weightService;
        private readonly ISortService<IWeighted> sortService;
        private readonly IMapper mapper;

        public BuildingSearchService(
            IDataService dataService,
            IFilterService<Building> filterService,
            IWeightService weightService,
            ISortService<IWeighted> sortService,
            IMapper mapper)
        {
            this.dataService=dataService;
            this.filterService=filterService;
            this.weightService=weightService;
            this.sortService=sortService;
            this.mapper=mapper;
        }
        public List<BuildingDto> Search(string searchText)
        {
            var data = dataService.FetchData();
            var buildings = data.Buildings.ToList();
            var filteredBuildings = filterService.Filter(buildings, searchText);
            var weightedBuildings = weightService.Calculate<Building, None, BuildingDto>(filteredBuildings, String.Empty, searchText);
            var mapped = mapper.Map<List<IWeighted>>(weightedBuildings);
            var sorted = sortService.Sort(mapped);
            var dtos = mapper.Map<List<BuildingDto>>(sorted);
            return dtos;
        }
    }
}
