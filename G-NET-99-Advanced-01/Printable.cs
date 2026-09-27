namespace G_NET_99_Advanced_01
{
    public interface Printable
    {
        void Print();
    }
    public class Document : Printable
    {
        public void Print()
        {
            Console.WriteLine("Document is printing successfully!");
        }
    }
    public class File : Printable
    {
        public void Print()
        {
            Console.WriteLine("File is printing successfully!");
        }
    }
    public class Printer<T> where T : Printable
    {
        public void PrintItem(T item)
        {
            item.Print(); // Safe to call 
        }
    }
}
