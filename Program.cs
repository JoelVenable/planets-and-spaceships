﻿using System;
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


    }
  }
}