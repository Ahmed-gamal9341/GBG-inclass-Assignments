abstract class Animal
{
    public string name { get; set; }
    public abstract void speak();
    public void sleep()
    {
        Console.WriteLine("zzzz");
    }
    public abstract string Sound { get; }


}

class Dog : Animal
{
    public Dog(string name)
    {
        this.name = name;
    }
    public override void speak()
    {
        Console.WriteLine(Sound);
    }
    public override string Sound
    {
        get { return "howhow"; }
    }
}

class Cat : Animal
{
    public Cat(string name)
    {
        this.name = name;
    }
    public override string Sound
    {
        get { return "mewo"; }
    }


    public override void speak()
    {
        Console.WriteLine(Sound);
    }
}

class Bird : Animal
{
    public Bird(string name)
    {
        this.name = name;
    }
    public override string Sound
    {
        get { return "sew"; }
    }

    public override void speak()
    {
        Console.WriteLine(Sound);
    }
}
class Program
{
    static void Main()
    {
        Dog dog = new Dog("x");
        Cat cat = new Cat("y");
        Bird bird = new Bird("z");

        dog.speak();
        dog.sleep();

        cat.speak();
        cat.sleep();

        bird.speak();
        bird.sleep();
    }
}