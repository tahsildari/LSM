using LSM.Dto;
using LSM.Services.Sorting;

namespace LSM.Services.Application.Sorting
{
    public class SortService : ISortService<IWeighted>
    {
        public List<IWeighted> Sort(List<IWeighted> values)
        {
            return values.OrderByDescending(x => x.SearchWeight).ToList();
        }
    }
}
