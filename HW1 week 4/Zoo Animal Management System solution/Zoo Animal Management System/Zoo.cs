using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Animal_Management_System
{
    internal class Zoo
    {
        public void AddAnimal(Animals animal, string enclosureName)
        {
            Console.WriteLine($"Animal {animal.Name} added to {enclosureName} enclosure.");
        }

        public void DisplayEnclosure(string enclosureName)
        {
            Console.WriteLine($"No detailed information available for {enclosureName} enclosure.");
        }
    }
}
