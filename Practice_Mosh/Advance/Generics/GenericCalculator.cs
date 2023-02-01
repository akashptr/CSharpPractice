namespace Practice_Mosh.Advance.Generics
{
    public class GenericCalculator
    {
        public static T Max<T>(T o1, T o2) where T : IComparable<T>
        {
            return o1.CompareTo(o2) > 0 ? o1 : o2;
        }
    }
}