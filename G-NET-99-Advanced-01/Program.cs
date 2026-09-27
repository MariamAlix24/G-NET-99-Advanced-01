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
            #region Q5
            int maxNumber = Math.FindMax(10, 20);
            Console.WriteLine(maxNumber);
            #endregion
            #region Q6
            // A generic interface is an interface defined with a type parameter <T>. 
            // It allows defining a common set of method signatures that can work 
            // with any data type.
            Simple task = new Simple();
            task.Add("mac");
            string result = task.GetById(66);
            Console.WriteLine(result);
            task.Add("iphone17");
            string result1 = task.GetById(695);
            Console.WriteLine(result1);
            #endregion
            #region Q7
            // The 'struct' constraint (where T : struct) specifies that 
            // the type parameter T must be a value type (like int, double, or bool).
            Calculator<int> teststuctvalue = new Calculator<int>();//int is struct
            teststuctvalue.Number = 10;
            #endregion
            #region Q8
            // The 'class' constraint (where T : class) specifies that 
            // the type parameter T must be a reference type (like a class or string).
            Data<string> dataref = new Data<string>();
            #endregion
            #region Q9
            // The 'new()' constraint specifies that the type parameter T must have 
            // a public parameterless constructor. 
            // This allows you to instantiate objects of type T using 'new T()'.
            CreatNew<Car> creator = new CreatNew<Car>();
            Car myCar = creator.CreateInstance();
            Console.WriteLine("Car Name: " + myCar.Name);
            #endregion
            #region Q10
            // The interface constraint (where T : IInterfaceName) specifies that 
            // the type parameter T must implement a specific interface. 
            // This ensures that T contains all the methods defined by that interface.
            Document mydocument = new Document();
            Printer<Document> myprinter = new Printer<Document>();
            myprinter.PrintItem(mydocument);
            File fileone = new File();
            Printer<File> myprinter1 = new Printer<File>();
            myprinter1.PrintItem(fileone);
            #endregion
            #region Q11
            // The base class constraint (where T : BaseClassName) specifies that 
            // the type parameter T must inherit from a specific base class, 
            // or be that base class itself.
            AnimalShelter<Dog> dogShelter = new AnimalShelter<Dog>();
            AnimalShelter<Cat> catShelter = new AnimalShelter<Cat>();
            #endregion
            #region Q12
            // Multiple constraints are applied by separating them with commas after 'where T :'.
            // Order rule: Class/Base class constraint first, then Interfaces, then new() last.
            #endregion
            #region Q13
            Defult<int> intContainer = new Defult<int>();
            int defaultInt = intContainer.GetDefaultValue(); // Result: 0
            Console.WriteLine(defaultInt);
            Defult<string> strContainer = new Defult<string>();
            string defaultStr = strContainer.GetDefaultValue(); // Result: null
            Console.WriteLine("NULL" + defaultStr);
            #endregion
            #region Q14
            SafeList<string> names = new SafeList<string>();
            names.Add("Ahmed");
            names.Add("Mona");
            Console.WriteLine(names.GetAt(0));
            Console.WriteLine(names.GetAt(10) ?? "Invalid Index!");
            #endregion
            #region Q15
            // Covariance allows you to use a more derived type (child class) 
            // than originally specified.
            // The 'out' keyword enables covariance on a generic type parameter (T).
            // It restricts T to be used only as a return type (output) of methods, 
            // never as an input parameter.
            #endregion
        }
    }
}
