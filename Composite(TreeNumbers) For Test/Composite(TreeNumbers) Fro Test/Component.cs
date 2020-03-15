using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_TreeNumbers__Fro_Test
{
    public abstract class Component
    {
        protected int Number;
        public Component(int number)
        {
            this.Number = number;
        }

        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();

        public abstract int Sum();

        public int GetNumber()
        {
            return this.Number;
        }
    }
}

