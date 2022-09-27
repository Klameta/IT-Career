using System;
using System.Collections.Generic;
using System.Text;

namespace _01.AnimalKingdomePartTwo
{
    public interface IAnimal : IMakeNoise, IMakeTrick
    {
        public string Perfom();
    }
}
