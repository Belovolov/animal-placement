using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlacement
{
    public abstract class AnimalView
    {
        private AnimalsModel myModel;
        public AnimalView(AnimalsModel model)
        {
            myModel = model;
        }
    }
}
