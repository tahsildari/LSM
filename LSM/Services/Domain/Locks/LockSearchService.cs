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
    public class LockSearchService : ISearchService<LockDto>
    {
        private readonly IDataService dataService;
        private readonly IFilterService<Lock> filterLockService;
        private readonly IWeightService weightService;
        private readonly ISortService<IWeighted> sortService;
        private readonly IMapper mapper;

        public LockSearchService(
            IDataService dataService,
            IFilterService<Lock> filterLockService,
            IWeightService weightService,
            ISortService<IWeighted> sortService,
            IMapper mapper)
        {
            this.dataService=dataService;
            this.filterLockService=filterLockService;
            this.weightService=weightService;
            this.sortService=sortService;
            this.mapper=mapper;
        }

        public List<LockDto> Search(string searchText)
        {
            var data = dataService.FetchData();
            var locks = LoadLockBuildings(data);
            var filteredLocks = filterLockService.Filter(locks, searchText);
            var weightedLocks = weightService.Calculate<Lock, Building, LockDto>(filteredLocks, nameof(Building), searchText);
            var mapped = mapper.Map<List<IWeighted>>(weightedLocks);
            var sorted = sortService.Sort(mapped);
            var dtos = mapper.Map<List<LockDto>>(sorted);
            return dtos;
        }

        private List<Lock> LoadLockBuildings(DataFile data)
        {
            var locks = data.Locks;
            var buildings = data.Buildings;

            foreach (Lock @lock in locks)
            {
                @lock.Building = buildings.FirstOrDefault(x => x.Id == @lock.BuildingId);
            }

            return locks.ToList();
        }
    }
}
