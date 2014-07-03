using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Fido"));
            dogs.Add(new Dog("Bob"));
            dogs.Add(new Dog("Adam"));
            for each(Dog dog in dogs)
                Console.WriteLine(dogs.Describe());
            Console.ReadKey();

        }
    }

    interface IAnimal
    {

        string Describe();

        string Name
        {

            get;

            set;

        }

    }
    class Dog : IAnimal, IComparable
    {

        private string name;

        public Dog(string name)
        {

            this.Name = name;

        }

        public string Describe()
        {

            return "Hello, I'm a dog and my name is " + this.Name;

        }

        public int CompareTo(object obj)
        {

            if (obj is IAnimal)

                return this.Name.CompareTo((obj as IAnimal).Name);

            return 0;

        }

        public string Name
        {

            get { return name; }

            set { name = value; }

        }

    }
}
