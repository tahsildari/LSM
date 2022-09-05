using AutoMapper;
using LSM.Dto;
using LSM.Entities;
using LSM.Extensions;
using LSM.Services.Data;
using LSM.Services.Filter;
using LSM.Services.Sorting;
using LSM.Services.Weight;

namespace LSM.Services.Domain.Groups
{
    public class GroupSearchService : ISearchService<GroupDto>
    {
        private readonly IDataService dataService;
        private readonly IFilterService<Group> filterService;
        private readonly IWeightService weightService;
        private readonly ISortService<IWeighted> sortService;
        private readonly IMapper mapper;

        public GroupSearchService(
            IDataService dataService,
            IFilterService<Group> filterService,
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
        public List<GroupDto> Search(string searchText)
        {
            Check.NotEmpty(searchText, nameof(searchText));

            var data = dataService.FetchData();
            var groups = data.Groups.ToList();
            var filteredBuildings = filterService.Filter(groups, searchText);
            var weightedBuildings = weightService.Calculate<Group, None, GroupDto>(filteredBuildings, String.Empty, searchText);
            var mapped = mapper.Map<List<IWeighted>>(weightedBuildings);
            var sorted = sortService.Sort(mapped);
            var dtos = mapper.Map<List<GroupDto>>(sorted);
            return dtos;
        }
    }
}
