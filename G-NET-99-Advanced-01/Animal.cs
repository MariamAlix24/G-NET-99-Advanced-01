namespace G_NET_99_Advanced_01
{
    //Q11
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal { }
    public class Cat : Animal { }
    public class AnimalShelter<T> where T : Animal
    {
        public void Feed(T animal)
        {
            animal.Eat();
        }
    }
}
