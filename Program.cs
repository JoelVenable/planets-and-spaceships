using System;
using System.Collections.Generic;

namespace spaceships
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() {
                "Mercury", "Mars"
            };

      planetList.Add("Jupiter");

      List<string> morePlanets = new List<string>() {
                "Saturn", "Uranus"
        };

      planetList.AddRange(morePlanets);

      planetList.Insert(1, "Venus");

      planetList.Insert(2, "Earth");

      planetList.Add("Pluto");

      //  Shallow copy!!
      List<string> rockyPlanets = planetList.GetRange(0, 4);


      planetList.ForEach(planet => Console.WriteLine(planet));
      rockyPlanets.ForEach(planet => Console.WriteLine(planet));

    }
  }
}