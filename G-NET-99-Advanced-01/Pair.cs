namespace G_NET_99_Advanced_01
{
    //Q3
    internal class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
