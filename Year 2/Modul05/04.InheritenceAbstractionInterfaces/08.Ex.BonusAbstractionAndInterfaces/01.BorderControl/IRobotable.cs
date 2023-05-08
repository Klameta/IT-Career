using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BorderControl
{
    class Robot : IInhabitant
    {
        private string id;
        private string model;


        public string Id { get => id; private set => id = value; }
        public string Model
        {
            get { return model; }
            private set { model = value; }
        }
        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }

        public override string ToString()
        {
            return $"{Id}";
        }

    }
}
