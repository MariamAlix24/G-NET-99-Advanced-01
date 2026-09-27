namespace G_NET_99_Advanced_01
{
    //Q5
    internal class Math
    {
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            return b;
        }
    }
}
