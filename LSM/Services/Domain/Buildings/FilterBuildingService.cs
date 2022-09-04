using LSM.Entities;
using LSM.Extensions;
using LSM.Services.Filter;

namespace LSM.Services.Domain.Locks
{
    public class FilterBuildingService : IFilterService<Building>
    {
        public List<Building> Filter(List<Building> buildings, string text)
        {
            var filteredData = buildings.Where(b =>
                b.Name.ContainsIgnoreCase(text) ||
                b.Description.ContainsIgnoreCase(text) ||
                b.Shortcut.ContainsIgnoreCase(text)
            );

            return filteredData.ToList();
        }
    }
}
