using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Animals
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
            Wildebeest()
            {
                Weight = 50;
                Life = true;
            }
            public override void EatGrass()
            {
                Weight += 10;
            }
        }
        public class Bison : Herbivore
        {
            Bison()
            {
                Weight = 50;
                Life = true;
            }
            public override void EatGrass()
            {
                Weight += 20;
            }
        }
        public class Lion : Carnivore
        {
            Lion()
            {
                Power = 100;
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
            Wolf()
            {
                Power = 100;
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
