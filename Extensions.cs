namespace BlazorGenericTablePOC
{
    public static class Extensions
    {
        public static ICollection<T> OrderByDynamic<T>(this ICollection<T> source, string property, string order) 
        { 
            if (order == "ASC")
            {
                return source.OrderBy(x => x.GetType().GetProperty(property).GetValue(x)).ToList();
            }

            if(order == "DESC")
            {
                return source.OrderByDescending(x => x.GetType().GetProperty(property).GetValue(x)).ToList();
            }

            return source;
        }
    }
}
