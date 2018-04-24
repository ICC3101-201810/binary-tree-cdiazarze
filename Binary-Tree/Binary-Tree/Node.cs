using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Node<T>
    {
        private T information { get; }
        private Node<T> parentNode { get;}
        private Node<T> rChildNode { get; set; }
        private Node<T> lChildNode { get; set; }

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

        public T GetInformation()
        {
            try
            {
                return this.information;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void AddRightChild(T information)
        {
            try
            {
                rChildNode = new Node<T>(information, this);
            }
            catch { throw; }
        }
        public void AddLeftChild(T information)
        {
            try
            {
                lChildNode = new Node<T>(information, this);
            }
            catch { throw; }
        }
        public Node<T> GetRChild()
        {
            try
            {
                return rChildNode;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No tiene hijo derecho");
                return this;
            }
        }
        public Node<T> GetLChild()
        {
            try
            {
                return lChildNode;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No tiene hijo Izquierdo");
                return this;
            }
        }
        public Node<T> GetParent()
        {
            try
            {
                return parentNode;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No tiene padre");
                return this;
            }
        }
        public void Remove()
        {
            
        }
    }

}
