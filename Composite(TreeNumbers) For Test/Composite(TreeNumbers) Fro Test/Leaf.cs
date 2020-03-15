using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_TreeNumbers__Fro_Test
{
    public class Leaf : Component
    {
        public Leaf(int number) : base(number)
        {
            Number = number;
        }
        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf element cannot add child!");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf element has not children");
        }

        public override int Sum()
        {
            return this.GetNumber();
        }
    }
}
