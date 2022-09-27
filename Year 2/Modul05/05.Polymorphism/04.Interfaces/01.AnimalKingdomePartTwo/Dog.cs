using System;
using System.Collections.Generic;
using System.Text;

namespace _01.AnimalKingdomePartTwo
{
    class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Woof!";
        }

        public string MakeTrick()
        {
            return "Hold my paw human!";
        }

        public string Perfom()
        {
            return $"{MakeNoise()}\n{MakeTrick()}";

        }
    }
}
