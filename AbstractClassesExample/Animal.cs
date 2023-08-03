using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExample
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //using abstract allows you to create a "stubbed out" method
        //using abstract means you HAVE TO use the override keyword in derived classes
        public abstract void AbstractAnimal();

        //using virtual means DO NOT have to use the override keyword if you choose not to
        public virtual void VirtualAnimal()
        {
            Console.WriteLine("Animal is virtual");
        }
    }
}
