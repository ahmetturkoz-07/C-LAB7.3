using System;

public class Animal
{
    public string Name;
    public int Age;

    public Animal(string animalName, int animalAge)
    {
        Name = animalName;
        Age = animalAge;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound");
    }
}


public class Dog : Animal
{
    public string Breed;

    public Dog(string dogName, int dogAge, string dogBreed)
        : base(dogName, dogAge)
    {
        Breed = dogBreed;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Woof!");
    }
}


public class Cat : Animal
{
    public Cat(string catName, int catAge)
        : base(catName, catAge)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Meow!");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Karabas", 3, "Kangal");
        Cat cat = new Cat("Tekir", 2);

        Animal[] animals = { dog, cat };

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}
