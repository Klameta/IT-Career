using System;
using System.Collections.Generic;
using System.Text;

namespace _01.AnimalKingdomePartTwo
{
    class Trainer
    {
        public IAnimal Animal { get; set; }

        public Trainer(IAnimal animal)
        {
            Animal = animal;
        }

        public string Make()
        {
            return Animal.Perfom();
        }
    }
}
