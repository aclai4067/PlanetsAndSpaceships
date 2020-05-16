using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            var missionVisits = new Dictionary<string, List<string>>();
            missionVisits.Add("Voyager 1", new List<string>() { "Jupiter", "Saturn" });
            missionVisits.Add("Voyager 2", new List<string>() { "Jupiter", "Saturn", "Uranus", "Neptune" });
            missionVisits.Add("Mariner 10", new List<string>() { "Mercury", "Venus" });
            missionVisits.Add("Pioneer 11", new List<string>() { "Jupiter", "Saturn" });
            missionVisits.Add("Dawn", new List<string>() { "Mars" });



            foreach (var p in planetList){
                Console.WriteLine($"The following mission(s) visited {p}:");
                foreach (var (craft , planetsVisited) in missionVisits)
                {
                    if (planetsVisited.Contains(p))
                    {
                        Console.WriteLine(craft);
                    }
                }
            }

            foreach(var r in rockyPlanets){
                Console.WriteLine($"rocky: {r}");
            }
        }
    }
}
