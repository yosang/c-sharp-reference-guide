namespace Program
{

    class App
    {
        public delegate void MyDelegate(string s);
        public static void Main()
        {
            // Using a delegate with an instance of a class
            Dog myPet = new Dog();
            myPet.makeSound("barks"); // Calling makeSound directly from the class

            MyDelegate del = myPet.makeSound;
            del("Woof woof"); // Calling makeSound directly from the delegate

            MyDelegate del2 = Dog.sleep;
            del2("the dog sleeps without making a sound"); // Calling the delegate directly from without making an instance

            MyDelegate multiCast = del + del2; // We can cast multiple delegates by creating a new delegate
            multiCast("standard sound"); // with one single string, equivalent to = sleep("standard sound"), makesound("standardsound")

        }
    }
    class Dog
    {
        public void makeSound(string sound)
        {
            Console.WriteLine(sound);
        }

        public static void sleep(string sound)
        {
            Console.WriteLine(sound);
        }
    }


}