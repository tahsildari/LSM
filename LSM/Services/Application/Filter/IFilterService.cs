namespace LSM.Services.Filter
{
    public interface IFilterService<T>
    {
        List<T> Filter(List<T> data, string text);
    }
}
