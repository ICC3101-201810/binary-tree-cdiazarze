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
        //public Node<T> parentNode {get;}
        public Node<T> rChildNode {get; set;}
        public Node<T> lChildNode {get; set;}

        public Node(T information)
        {
            this.information = information;
            rChildNode = null;
            lChildNode = null;
        }


    }

}
