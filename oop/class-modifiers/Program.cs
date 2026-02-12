// Villain Joker = new Villain(); // Wont work, this class is static, so we cant create an instance of it
SuperHero Batman = new SuperHero();

Batman.Attack();
// Batman.Surrender(); // class members are private by default = 'SuperHero.Surrender()' is inaccessible due to its protection level

// Batman.Identify(); // Its static, cant be accessed with an instance
SuperHero.Identify();

// Villain.Surrender(); // Throws an error = 'Villain.Surrender()' is inaccessible due to its protection level

public class SuperHero
{
    public void Attack()
    {
        Console.WriteLine("Feel my power!");
    }

    public static void Identify()
    {
        Console.WriteLine("Im the good guy");
    }
    void Surrender()
    {
        Console.WriteLine("Never!");
    }
}
static class Villain
{
    static void Surrender() // Since the class is static, this method cannot be public and must be static
    {
        Console.WriteLine("I will never surrender");
    }
}