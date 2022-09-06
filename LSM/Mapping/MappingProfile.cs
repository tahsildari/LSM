using AutoMapper;
using LSM.Dto;
using LSM.Entities;

namespace LSM.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Building, BuildingDto>();
            CreateMap<Building, LockBuildingDto>();
            CreateMap<Lock, LockDto>();
            CreateMap<Group, GroupDto>();
            CreateMap<Group, MediaGroupDto>();
            CreateMap<Medium, MediaDto>();
        }
    }

}
