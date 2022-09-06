using LSM.Entities;
using LSM.Extensions;
using LSM.Services.Filter;

namespace LSM.Services.Domain.Locks
{
    public class FilterMediaService : IFilterService<Medium>
    {
        public List<Medium> Filter(List<Medium> media, string text)
        {
            var filteredData = media.Where(m =>
                m.Type.ToString().ContainsIgnoreCase(text) ||
                m.Owner.ContainsIgnoreCase(text) ||
                m.SerialNumber.ContainsIgnoreCase(text) ||
                m.Description.ContainsIgnoreCase(text) ||
                m.Group.Name.ContainsIgnoreCase(text) ||
                m.Group.Description.ContainsIgnoreCase(text)
            );

            return filteredData.ToList();
        }
    }
}
