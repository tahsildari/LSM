using AutoMapper;
using LSM.Dto;
using LSM.Entities;
using LSM.Extensions;
using LSM.Services.Application.Sorting;
using LSM.Services.Data;
using LSM.Services.Domain;
using LSM.Services.Domain.Locks;
using LSM.Services.Filter;
using LSM.Services.Sorting;
using LSM.Services.Weight;

namespace LSM.Services.Locks
{
    public class MediaSearchService : ISearchService<MediaDto>
    {
        private readonly IDataService dataService;
        private readonly IFilterService<Medium> filterLockService;
        private readonly IWeightService weightService;
        private readonly ISortService<IWeighted> sortService;
        private readonly IMapper mapper;

        public MediaSearchService(
            IDataService dataService,
            IFilterService<Medium> filterLockService,
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

        public List<MediaDto> Search(string searchText)
        {
            Check.NotEmpty(searchText, nameof(searchText));

            var data = dataService.FetchData();
            var media = LoadMediaGroups(data);
            var filteredMedia = filterLockService.Filter(media, searchText);
            var weightedMedia = weightService.Calculate<Medium, Group, MediaDto>(filteredMedia, nameof(Group), searchText);
            var mapped = mapper.Map<List<IWeighted>>(weightedMedia);
            var sorted = sortService.Sort(mapped);
            var dtos = mapper.Map<List<MediaDto>>(sorted);
            return dtos;
        }

        private List<Medium> LoadMediaGroups(DataFile data)
        {
            var media = data.Media;
            var groups = data.Groups;

            foreach (Medium @medium in media)
            {
                @medium.Group = groups.FirstOrDefault(x => x.Id == @medium.GroupId);
            }

            return media.ToList();
        }
    }
}
