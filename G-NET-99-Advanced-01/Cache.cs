namespace G_NET_99_Advanced_01
{
    //Q20 
    //Importaaaantt Note :
    // I worked on this solution with the help of AI as a study buddy to help me understand the concept and structure the code cleanly :))) sorry
    public class Cache<TKey1, TValue1>
    {
        struct CacheItem
        {
            public TKey1 Key;
            public TValue1 Value;
            public DateTime Expiry;
        }
        private CacheItem[] _items = new CacheItem[100];
        private int _count = 0;
        public void Add(TKey1 key, TValue1 value, int seconds)
        {
            _items[_count].Key = key;
            _items[_count].Value = value;
            _items[_count].Expiry = DateTime.Now.AddSeconds(seconds);
            _count++;
        }
        public bool Contains(TKey1 key)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Key != null && _items[i].Key.Equals(key))
                {
                    if (DateTime.Now > _items[i].Expiry)
                    {
                        _items[i] = default;
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }
        public TValue1 Get(TKey1 key)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Key.Equals(key) && Contains(key))
                {
                    return _items[i].Value;
                }
            }
            return default(TValue1);
        }
        public bool Remove(TKey1 key)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Key != null && _items[i].Key.Equals(key))
                {
                    _items[i] = default;
                    return true;
                }
            }
            return false;
        }
    }
}
