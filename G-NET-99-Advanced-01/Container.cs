namespace G_NET_99_Advanced_01
{
    //Q2
    internal class Container<T>
    {
        private T item;
        public void Add(T item1)
        {
            item = item1;
        }
        public T Get()
        {
            return item;
        }
    }
}
