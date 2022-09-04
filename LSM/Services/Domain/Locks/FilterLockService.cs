using LSM.Entities;
using LSM.Extensions;
using LSM.Services.Filter;

namespace LSM.Services.Domain.Locks
{
    public class FilterLockService : IFilterService<Lock>
    {
        public List<Lock> Filter(List<Lock> locks, string text)
        {
            var filteredData = locks.Where(l =>
                l.Name.ContainsIgnoreCase(text) ||
                l.SerialNumber.ContainsIgnoreCase(text) ||
                l.Floor.ContainsIgnoreCase(text) ||
                l.RoomNumber.ContainsIgnoreCase(text) ||
                l.Description.ContainsIgnoreCase(text) ||
                l.Type.ToString().ContainsIgnoreCase(text) ||
                l.Building.Name.ContainsIgnoreCase(text) ||
                l.Building.Description.ContainsIgnoreCase(text) ||
                l.Building.Shortcut.ContainsIgnoreCase(text)
            );

            return filteredData.ToList();
        }
    }
}
