using KilKellyJA10.AbstractClass;

namespace KilkellyJA10;

class Program
{
    static void Main(string[] args)
    {
       List<Animal> zoo = new List<Animal>
       {
        new Giraffe{Name = "giraffe"},
        new Seal {Name = "seal"},
        new Parrot{Name = "parrot"},
        new HighlandCow{Name = "highLandCow"}
       };

       foreach (var animal in zoo)
       {
        Console.WriteLine(animal.Name);
        animal.MakeSound();
        animal.Eat();
       }
    }
}
