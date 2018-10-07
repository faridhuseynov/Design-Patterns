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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
