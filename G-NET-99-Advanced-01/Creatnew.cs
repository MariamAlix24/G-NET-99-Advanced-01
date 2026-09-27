namespace G_NET_99_Advanced_01
{
    internal class CreatNew<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T(); //new()
        }

    }
    public class Car
    {
        public string Name { get; set; } = "Toyota";
    }
}
