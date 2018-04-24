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
            node1.AddRightChild(1); //Añadir hijo derecho
            node1.AddLeftChild(2); //Añadir hijo derecho
            Console.WriteLine(node1.GetInformation());
            Console.WriteLine(node1.GetRChild().GetInformation()); //ver info hijo derecho
            Console.WriteLine(node1.GetRChild().GetParent().GetInformation()); //ver padre del hijo derecho
            Console.WriteLine(node1.GetLChild().GetParent().GetInformation());//ver padre del hijo l
            node1.GetLChild().GetRChild(); //Probando exeption
            Console.ReadKey();
        }
    }
}
