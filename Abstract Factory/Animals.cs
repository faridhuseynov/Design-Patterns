using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Animals
    {
        public abstract class Herbivore
        {
            public int Weight;
            public abstract void EatGrass();
            public bool Life; 
        }
        public abstract class Carnivore
        {
            public int Power;
            public abstract void EatHerbivore(Herbivore herbivore);
        }
        public class Wildebeest : Herbivore
        {
            public Wildebeest()
            {
                Weight = 50;
                Life = true;
                Console.WriteLine("Wildebeest created");
            }
            public override void EatGrass()
            {
                Weight += 10;
                Console.WriteLine(Weight);
            }
        }
        public class Bison : Herbivore
        {
            public Bison()
            {
                Weight = 50;
                Life = true;
                Console.WriteLine("Bison created");
            }
            public override void EatGrass()
            {
                Weight += 20;
            }
        }
        public class Lion : Carnivore
        {
            public Lion()
            {
                Power = 100;
                Console.WriteLine("Lion created");
            }
            public override void EatHerbivore(Herbivore herbivore)
            {
                if (herbivore.Life != false)
                {
                    if (Power > herbivore.Weight)
                    {
                        Power += 10;
                        herbivore.Weight -= 10;
                        if (herbivore.Weight == 0)
                        {
                            herbivore.Life = false;
                        }
                    }
                    else
                    {
                        if (Power != 0)
                        {
                            Power -= 10;
                        }
                    }
                }
            }
        }
        public class Wolf : Carnivore
        {
            public Wolf()
            {
                Power = 100;
                Console.WriteLine("Wolf created");
            }
            public override void EatHerbivore(Herbivore herbivore)
            {
                if (herbivore.Life != false)
                {
                    if (Power > herbivore.Weight)
                    {
                        Power += 10;
                        herbivore.Weight -= 10;
                        if (herbivore.Weight == 0)
                        {
                            herbivore.Life = false;
                        }
                    }
                    else
                    {
                        if (Power != 0)
                        {
                            Power -= 10;
                        }
                    }
                }
            }
        }
        public class Elk : Herbivore
        {
            public Elk()
            {
                Weight = 50;
                Life = true;
                Console.WriteLine("Elk created");
            }
            public override void EatGrass()
            {
                Weight += 10;
                Console.WriteLine(Weight);
            }
        }
        public class Tiger : Carnivore
        {
            public Tiger()
            {
                Power = 500;
                Console.WriteLine("Tiger created");
            }
            public override void EatHerbivore(Herbivore herbivore)
            {
                if (herbivore.Life != false)
                {
                    if (Power > herbivore.Weight)
                    {
                        Power += 10;
                        herbivore.Weight -= 10;
                        if (herbivore.Weight == 0)
                        {
                            herbivore.Life = false;
                        }
                    }
                    else
                    {
                        if (Power != 0)
                        {
                            Power -= 10;
                        }
                    }
                }
            }
        }
    }
}
