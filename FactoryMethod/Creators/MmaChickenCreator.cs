using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class MmaChickenCreator : ChickenCreator
    {
        public override Chicken FactoryMethod()
        {        
            return new CluckNorris();
        }
    }
}
