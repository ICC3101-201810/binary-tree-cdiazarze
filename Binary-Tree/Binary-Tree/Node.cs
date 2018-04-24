using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Node<T>
    {
        public T information { get; set; }
        public Node<T> parentNode {get;}
        public Node<T> rChildNode {get;}
        public Node<T> lChildNode {get;}

        public Node(T information)
        {
            this.information = information;
            rChildNode = null;
            lChildNode = null;
        }
        public Node(T information, Node<T> node)
        {
            this.information = information;
            parentNode = node;
            rChildNode = null;
            lChildNode = null;
        }

        public void AddChild(T information, Node<T> node)
        {
            node = new Node<T>(information,this);
        }

    }

}
