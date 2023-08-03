using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExample
{
    public class Cat : Animal
    {
        public override void AbstractAnimal()
        {
            Console.WriteLine("Cat is abstract");
        }

        public override void VirtualAnimal()
        {
            Console.WriteLine("Cat is virtual");
        }
    }
}
