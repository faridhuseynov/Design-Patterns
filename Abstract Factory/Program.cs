using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstract_Factory.Animals;
using static Abstract_Factory.Continents;

namespace Abstract_Factory
{
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
