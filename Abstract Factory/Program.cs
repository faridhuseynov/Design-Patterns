using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_Factory.Animals;

namespace Abstract_Factory
{
    public interface IContinent
    {
        Herbivore CreateFirstHerbivore();
        Carnivore CreateFirstCarnivore();
        Herbivore CreateSecondHerbivore();
        Carnivore CreateSecondCarnivore();
    }
    // Africa is the Factory Class, which should has its own flora and fauna
    public class Africa : IContinent
    {
        //method to create Lion in Africa
        public Carnivore CreateFirstCarnivore()
        {
            return new Lion();
        }

        //method to create Wolf in Africa
        public Carnivore CreateSecondCarnivore()
        {
            return new Wolf();
        }

        //method to create Wildebeest in Africa
        public Herbivore CreateFirstHerbivore()
        {
            return new Wildebeest();
        }

        //method to create Bison in Africa
        public Herbivore CreateSecondHerbivore()
        {
            return new Bison();
        }
    }

    // North America is the Factory Class, which should has its own flora and fauna
    public class NorthAmerica : IContinent
    {
        //method to create Lion in Africa
        public Carnivore CreateFirstCarnivore()
        {
            return new Lion();
        }

        //method to create Wolf in Africa
        public Carnivore CreateSecondCarnivore()
        {
            return new Wolf();
        }

        //method to create Wildebeest in Africa
        public Herbivore CreateFirstHerbivore()
        {
            return new Wildebeest();
        }

        //method to create Bison in Africa
        public Herbivore CreateSecondHerbivore()
        {
            return new Bison();
        }
    }

    //clint class
    public class AnimalWorld
    {
        //Continent that the animal world will be set to work
        public IContinent Continent { get; set; }
        //method to add herbivores based on the continent being selected
        public void AddHerbivore(List<Herbivore> herbivores)
        {
            herbivores.Add(Continent.CreateFirstHerbivore());
            herbivores.Add(Continent.CreateSecondHerbivore());
        }
        //method to add carnivore based on the continent being selected
        public void AddCarnivore(List<Carnivore> carnivores)
        {
            carnivores.Add(Continent.CreateFirstCarnivore());
            carnivores.Add(Continent.CreateSecondCarnivore());
        }
        //method for herbivores to eat
        public void MealsHerbivores(List<Herbivore> herbivores)
        {
            foreach (var herbivore in herbivores)
            {
                herbivore.EatGrass();
            }
        }
        //method for carnivores to eat
        public void NutritionCarnivores(List<Carnivore>carnivores, List<Herbivore> herbivores)
        {
            //function where every carnivore attacks every herbivore
            for (int i = 0; i < carnivores.Count; i++)
            {
                for (int j = 0; j < herbivores.Count; j++)
                {
                    carnivores[i].EatHerbivore(herbivores[j]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
