using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class CluckNorris : Chicken
    {
        public override string Name { get; set; }

        public CluckNorris()
        {
            this.Name = "Cluck Norris";
        }
    }
}
