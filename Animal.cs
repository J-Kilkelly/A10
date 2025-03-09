namespace KilKellyJA10.AbstractClass;

public abstract class Animal
{
    public required string Name { get; set; }
    public abstract void MakeSound();
    public virtual void Eat()
    {
        Console.WriteLine("This animal eats food.");
    }
}

public class Giraffe : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("This giraffe grunts.");
    }

    public override void Eat()
    {
        Console.WriteLine("This giraffe eats tree leaves.");
    }
}

public class Seal : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("This seal barks.");
    }

    public override void Eat()
    {
        Console.WriteLine("This seal eats fish.");
    }
}

public class Parrot : Animal
{
    public override void MakeSound() => Console.WriteLine("This parrot talks.");

    public override void Eat() => Console.WriteLine("This parrot eats seeds.");
}

public class HighlandCow : Animal
{
    public override void MakeSound() => Console.WriteLine("This cow Moos.");

    public override void Eat() => Console.WriteLine("This cow eats hay.");
}


