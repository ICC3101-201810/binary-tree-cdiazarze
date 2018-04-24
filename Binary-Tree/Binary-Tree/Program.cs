using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> node1 = new Node<int>(0);
            node1.AddChild(1, node1.rChildNode); //Añadir hijo derecho
            Console.WriteLine(node1.information);
            Console.WriteLine(node1.rChildNode.information);//ver padre del hijo
            Console.ReadKey();
        }
    }
}
