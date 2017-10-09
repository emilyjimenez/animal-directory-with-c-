using System;
using System.Collections.Generic;

class Animal
{
  public string Name;
  public int Age;
  public string Species;
}

public class AnimalInfo
{
  public static void Main()
  {
    Animal dog = new Animal();
    dog.Name = "Fido the dog";
    dog.Age = 7;
    dog.Species = "Alaskan";

    Animal cat = new Animal();
    cat.Name = "Fluffy the cat";
    cat.Age =3;
    cat.Species = "Himalayan";

    Animal bird = new Animal();
    bird.Name = "Squeeky the bird";
    bird.Age = 1;
    bird.Species = "Parrot";

    List<Animal> Animals = new List<Animal>() { dog, cat, bird };
    foreach(Animal mammal in Animals)
    {
      Console.WriteLine(mammal.Name);
    }

    Console.WriteLine("Enter Age: ");
    string stringMaxAge = Console.ReadLine();
    int maxAge = int.Parse(stringMaxAge);

    List<Animal> AnimalsMatchingSearch = new List<Animal>();

    foreach(Animal mammal in Animals)
    {
      if (mammal.Age < maxAge)
      {
        AnimalsMatchingSearch.Add(mammal);
      }
    }

    foreach(Animal mammal in AnimalsMatchingSearch)
    {
      Console.WriteLine(mammal.Name);
    }
  }
}
