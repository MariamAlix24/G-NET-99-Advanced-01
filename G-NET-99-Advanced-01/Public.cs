namespace G_NET_99_Advanced_01
{
    //19
    public class Parent<T>
    {
        public T Data;
    }
    //Specifying the type directly (string)
    public class StringChild : Parent<string>
    {
    }
    //Keeping the child generic too <T>
    public class GenericChild<T> : Parent<T>
    {
    }
}
