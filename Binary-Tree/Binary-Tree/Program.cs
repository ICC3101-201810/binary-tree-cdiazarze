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
            Node<String> node1 = new Node<String>("Hello");
            node1.AddRightChild("World"); //Añadir hijo derecho
            node1.AddLeftChild("I dont know what Im doing here"); //Añadir hijo derecho
            node1.GetParent();//Probando sin padre
            Console.WriteLine(node1.GetInformation());
            Console.WriteLine("Probando hijo D:");
            Console.WriteLine(node1.GetRChild().GetInformation()); //ver info hijo derecho
            Console.WriteLine(node1.GetRChild().GetParent().GetInformation()); //ver padre del hijo derecho
            Console.WriteLine("Probando hijo I:");
            Console.WriteLine(node1.GetLChild().GetInformation());//ver info hijo 2
            Console.WriteLine(node1.GetLChild().GetParent().GetInformation());//ver Padre hijo 2
            node1.GetLChild().GetLChild(); //Probando exeption
            node1.GetRChild().AddLeftChild("Hello! Im the left child of the right child");
            node1.GetRChild().GetRChild(); //Probando exeption
            node1.GetRChild().GetLChild().GetInformation();
            Console.ReadKey();
        }
    }
}
