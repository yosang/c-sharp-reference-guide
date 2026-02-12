Dog myPet = new Dog("Ella");
Cat neighboursPet = new Cat("King");

myPet.speak();
neighboursPet.speak();
public class Animal
{
    public string name; // Field

    public Animal(string n) // The constructor, takes a string
    {
        name = n; // Assigns n to name.
    }

    public virtual void speak() // The virtual modifier allows subclasses to override the logic of this method
    {
        Console.WriteLine("Animal sound");
    }
}
public class Dog : Animal
{
    public Dog(string n) : base(n) { } // The constructor of Dog

    public override void speak()
    {
        Console.WriteLine("Woof");
    }
}

public class Cat : Animal
{
    public Cat(string n) : base(n) { }
    public override void speak()
    {
        Console.WriteLine("Meew!");
    }
}