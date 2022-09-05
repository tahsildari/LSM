using LSM.Entities;
using LSM.Extensions;
using LSM.Services.Filter;

namespace LSM.Services.Domain.Groups
{
    public class FilterGroupService : IFilterService<Group>
    {
        public List<Group> Filter(List<Group> groups, string text)
        {
            var filteredData = groups.Where(g =>
                g.Name.ContainsIgnoreCase(text) ||
                g.Description.ContainsIgnoreCase(text)
            );

            return filteredData.ToList();
        }
    }
}
