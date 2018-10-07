using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_Factory.Animals;

namespace Abstract_Factory
{
    public abstract class Continent
    {
        public List<Herbivore> herbivores;
        public List<Carnivore> carnivores;
        public abstract Carnivore CreateCarnivore();
        public abstract Herbivore CreateHerbivore();
    }
    // Africa is the Factory Class, which should has its own flora and fauna
    public class Africa : Continent
    {
        //constructor to initialize list of carnivores and herbivores
        public Africa()
        {
            herbivores = new List<Herbivore>();
            carnivores = new List<Carnivore>();
        }
        //method to create Lion in Africa
        public  override Carnivore CreateCarnivore()
        {
            var rnd = new Random(DateTime.Now.Second);
            var selection = rnd.Next(0, 100);
            if (selection%2==0)
                return new Lion();
            else
                return new Wolf();
        }

        //method to create Wildebeest or Bison in Africa
        public override Herbivore CreateHerbivore()
        {
            var rnd = new Random(DateTime.Now.Second);
            var selection = rnd.Next(0, 100);
            if (selection % 2 == 0)
                return new Wildebeest();
            else
                return new Bison();
        }
    }

    // North America is the Factory Class, which should has its own flora and fauna
    public class NorthAmerica : Continent
    {
        //constructor to initialize list of carnivores and herbivores
        public NorthAmerica()
        {
            herbivores = new List<Herbivore>();
            carnivores = new List<Carnivore>();
        }
        //method to create Lion or Wolf in North America
        public override Carnivore CreateCarnivore()
        {
            var rnd = new Random(DateTime.Now.Second);
            var selection = rnd.Next(0, 100);
            if (selection % 2 == 0)
                return new Lion();
            else
                return new Wolf();
        }

        //method to create Wildebeest in North America
        public override Herbivore CreateHerbivore()
        {
            var rnd = new Random(DateTime.Now.Second);
            var selection = rnd.Next(0, 100);
            if (selection % 2 == 0)
                return new Wildebeest();
            else
                return new Bison();
        }
    }

    //client class
    public class AnimalWorld
    {
        //Continent that the animal world will be set to work
        public Continent Continent { get; set; }
        //method to add herbivores based on the continent being selected
        public void AddHerbivore(List<Herbivore> herbivores)
        {
            herbivores.Add(Continent.CreateHerbivore());
        }
        //method to add carnivore based on the continent being selected
        public void AddCarnivore(List<Carnivore> carnivores)
        {
            carnivores.Add(Continent.CreateCarnivore());
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

    // Eurasia is the Factory Class, which should has its own flora and fauna
    public class Eurasia : Continent
    {
        //constructor to initialize list of carnivores and herbivores
        public Eurasia()
        {
            herbivores = new List<Herbivore>();
            carnivores = new List<Carnivore>();
        }
        //method to create Lion or Wolf in Eurasia
        public override Carnivore CreateCarnivore()
        {
            var rnd = new Random(DateTime.Now.Second);
            var selection = rnd.Next(0, 100);
            if (selection % 2 == 0)
                return new Tiger();
            else
                return new Tiger();
        }

        //method to create Wildebeest in Eurasia
        public override Herbivore CreateHerbivore()
        {
            var rnd = new Random(DateTime.Now.Second);
            var selection = rnd.Next(0, 100);
            if (selection % 2 == 0)
                return new Elk();
            else
                return new Elk();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld animalWorld = new AnimalWorld();
            animalWorld.Continent = new Eurasia();
            animalWorld.AddCarnivore(animalWorld.Continent.carnivores);
            animalWorld.AddHerbivore(animalWorld.Continent.herbivores);
            animalWorld.AddHerbivore(animalWorld.Continent.herbivores);
            animalWorld.AddHerbivore(animalWorld.Continent.herbivores);
            animalWorld.AddHerbivore(animalWorld.Continent.herbivores);
            animalWorld.AddHerbivore(animalWorld.Continent.herbivores);
            animalWorld.AddCarnivore(animalWorld.Continent.carnivores);
            animalWorld.AddHerbivore(animalWorld.Continent.herbivores);
            animalWorld.AddHerbivore(animalWorld.Continent.herbivores);
            animalWorld.AddHerbivore(animalWorld.Continent.herbivores);
            animalWorld.AddCarnivore(animalWorld.Continent.carnivores);
            animalWorld.MealsHerbivores(animalWorld.Continent.herbivores);
            animalWorld.NutritionCarnivores(animalWorld.Continent.carnivores, animalWorld.Continent.herbivores);
            animalWorld.MealsHerbivores(animalWorld.Continent.herbivores);
        }
    }
}
