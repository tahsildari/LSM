namespace LSM.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsIgnoreCase(this string source, string search)
        {
            return source != null
                && source.Contains(
                    search,
                    StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
