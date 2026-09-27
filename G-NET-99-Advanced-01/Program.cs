namespace G_NET_99_Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //A generic class is a class designed to work with any data type.
            //Instead of specifying a fixed type, it uses a placeholder type
            //so you can define the actual data type later when creating the object.
            //Why use generics:
            // 1. Type Safety: Catches data type errors at compile time rather than runtime.
            // 2. Code Reusability: Allows writing one class that works with multiple data types.
            // 3. Cleaner Code: Eliminates the need for manual type casting.
            #endregion
            #region Q2
            //test Class Container
            Container<int> num = new Container<int>();
            num.Add(2566);
            Console.WriteLine(num.Get());
            Container<string> text = new Container<string>();
            text.Add("hahaha");
            Console.WriteLine(text.Get());
            #endregion
        }
    }
}
