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
            #region Q3
            //Multiple type parameters allow a generic class or method to work with
            //more than one placeholder data type like <TKey, TValue>.
            //This is useful when data needs to be stored in pairs or key-value relationships.
            //test class Pair
            Pair<int, string> mariam = new Pair<int, string>(1, "mariam ali");
            Console.WriteLine($"{mariam.Key}:{mariam.Value}");
            #endregion
            #region Q4
            // A generic method is a method defined with type parameters <T>, 
            // allowing it to process different data types using a single implementation.
            //test class SwapTest
            int firstnum = 5;
            int secondnum = 10;
            Console.WriteLine("Before Swap: firstnum = " + firstnum + ", secondnum = " + secondnum);
            SwapTest.Swap(ref firstnum, ref secondnum);
            Console.WriteLine("After Swap:  firstnum = " + firstnum + ", secondnum = " + secondnum);
            #endregion
        }
    }
}
