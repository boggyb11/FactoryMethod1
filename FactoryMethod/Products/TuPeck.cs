using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class TuPeck : Chicken
    {
        public override string Name { get; set; }

        public TuPeck()
        {
            this.Name = "Tu Peck";
        }
    }
}
