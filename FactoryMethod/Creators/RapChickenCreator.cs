using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class RapChickenCreator : ChickenCreator
    {
        public override Chicken FactoryMethod()
        {
            return new TuPeck();
        }
    }
}
