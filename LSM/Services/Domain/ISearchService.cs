namespace LSM.Services.Domain
{
    public interface ISearchService<T>
    {
        List<T> Search(string searchText);
    }
}
