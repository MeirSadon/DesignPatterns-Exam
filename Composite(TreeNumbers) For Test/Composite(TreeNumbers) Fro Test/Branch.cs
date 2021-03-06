using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_TreeNumbers__Fro_Test
{
    class Branch : Component
    {
        private IList<Component> childs = new List<Component>();

        public Branch(int number) : base(number)
        {
            this.Number = number;
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override int Sum()
        {
            int sum = this.GetNumber();

            foreach (Component c in childs)
            {
                sum += c.GetNumber();
            }

            return sum;
        }
    }
}

