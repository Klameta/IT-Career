using System;
using System.Collections.Generic;
using System.Text;

namespace _01.AnimalKingdomePartTwo
{
    class Cat : IAnimal
    {

        public string MakeNoise()
        {
            return "Meow!";
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }

        public string Perfom()
        {
            return $"{MakeNoise()}\n{MakeTrick()}";
        }
    }
}
