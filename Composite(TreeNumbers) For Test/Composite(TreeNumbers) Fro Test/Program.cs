using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_TreeNumbers__Fro_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Branch(0);
            Component l1 = new Leaf(1);
            Component l2 = new Leaf(2);
            root.AddChild(l1);
            root.AddChild(l2);

            Component b1 = new Branch(3);
            Component l3 = new Leaf(4);
            Component l4 = new Leaf(5);
            Component l5 = new Leaf(6);
            Component l6 = new Leaf(7);
            Component l7 = new Leaf(8);
            b1.AddChild(l3);
            b1.AddChild(l4);
            b1.AddChild(l5);
            b1.AddChild(l6);
            b1.AddChild(l7);

            root.AddChild(b1);

            Component b2 = new Branch(90);
            Component l8 = new Leaf(10);
            Component l9 = new Leaf(110);
            b2.AddChild(l8);
            b2.AddChild(l9);

            root.AddChild(b2);
            Component b3 = new Branch(12);

            root.AddChild(b3);


            Console.WriteLine($"Root Sum: {root.Sum()}");
            Console.WriteLine($"b1 Sum: {b1.Sum()}");

            Console.WriteLine($"root: {CheckIfEven(root)}"); //false;
            Console.WriteLine($"b2: {CheckIfEven(b2)}"); //true;

        }

        static bool CheckIfEven(Component element)
        {
            if (!(element.GetNumber() % 2 == 0))
                return false;

            if(element.GetChilds() == null)
            {
                if (!(element.GetNumber() % 2 == 0))
                    return false; // If It's Leaf Stop The Recusrion
            }
            else
            {
                foreach (Component c in element.GetChilds())
                {
                    if (!CheckIfEven(c))
                        return false;
                }
            }
            return true;
        }
    }
}
