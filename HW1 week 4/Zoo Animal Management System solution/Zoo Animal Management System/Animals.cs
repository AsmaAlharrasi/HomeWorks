using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Animal_Management_System
{
    public enum DietType
    {
        CARNIVORE,
        HERBIVORE,
        OMNIVORE
    }
    internal class Animals
    {
        public string Name;
        public int Age;
        public string Species;
        public DietType Diet;
        public Animals(string Name, int Age, string Species, DietType Diet)
        {
            this.Name = Name;
            this.Age = Age;
            this.Species = Species;
            this.Diet = Diet;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{this.Name} makes a sound.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{this.Name} moves.");
        }
    }

    internal class Reptile : Animals
    {
        public bool CanSwim;

        public Reptile(string Name, int Age, string Species, DietType Diet, bool CanSwim)
            : base(Name, Age, Species, Diet)
        {
            CanSwim = CanSwim;
        }

        public override void Move()
        {
            if (CanSwim)
                Console.WriteLine($"{this.Name} swims.");
            else
                Console.WriteLine($"{this.Name} moves by crawling.");
        }
    }

    internal class Mammal : Animals
    {
        public string FurColor;

        public Mammal(string Name, int Age, string Species, DietType Diet, string FurColor)
            : base(Name, Age, Species, Diet)
        {
            FurColor = FurColor;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.Name} makes sound.");
        }

        public void GiveBirth()
        {
            Console.WriteLine($"{this.Name} gives birth.");
        }
    }

    internal class Bird : Animals
    {
        public bool CanFly;

        public Bird(string Name, int Age, string Species, DietType Diet, bool CanFly)
            : base(Name, Age, Species, Diet)
        {
            CanFly = CanFly;
        }

        public override void Move()
        {
            if (CanFly)
                Console.WriteLine($"{this.Name} can fly.");
            else
                Console.WriteLine($"{this.Name} can move.");
        }
    }
}

