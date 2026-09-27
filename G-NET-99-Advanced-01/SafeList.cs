namespace G_NET_99_Advanced_01
{
    internal class SafeList<T>
    {
        private List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public T GetAt(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                return _items[index];
            }
            return default(T);
        }
    }
}

