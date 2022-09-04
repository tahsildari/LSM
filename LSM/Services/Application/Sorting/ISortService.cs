namespace LSM.Services.Sorting
{
    public interface ISortService<T>
    {
        List<T> Sort(List<T> values);
    }
}
