namespace G_NET_99_Advanced_01
{
    internal class SwapTest
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    public class Counter<T>
    {
        public static int Count = 0;
    }
}
