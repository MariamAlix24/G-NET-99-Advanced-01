namespace G_NET_99_Advanced_01
{
    //Q6
    internal interface IRepository<T>
    {
        void Add(T item);
        T GetById(int id);
    }
    public class Simple : IRepository<string>
    {
        private string Item = "";

        public void Add(string item)
        {
            Item = item;
            Console.WriteLine(" u Added new item : " + item);
        }
        public string GetById(int id)
        {
            return "Item name according the id number: " + Item;
        }
    }

}
