using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_244
{
    internal class BinarySearchTreeBuilder<T> where T : IComparable<T>
    {
        public T Nodedata { get; set; }
        public BinarySearchTreeBuilder<T> leftTree { get; set; }
        public BinarySearchTreeBuilder<T> rightTree { get; set; }

        public BinarySearchTreeBuilder(T nodeData)
        {
            this.Nodedata = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.Nodedata;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinarySearchTreeBuilder<T>(item);
                }
                else
                {
                    this.leftTree.Insert(item);
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new BinarySearchTreeBuilder<T>(item);
                }
                else
                {
                    this.rightTree.Insert(item);
                }
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {

                this.leftTree.Display();
            }
            Console.WriteLine(this.Nodedata.ToString());
            if (this.rightTree != null)
            {

                this.rightTree.Display();
            }

        }
        public bool Search(T element, BinarySearchTreeBuilder<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.Nodedata.Equals(element))
            {
                Console.WriteLine($"Found the element in BTS {node.Nodedata}");
                return true;
            }
            else
            {
                Console.WriteLine($"Current element is {node.Nodedata}");
            }
            if (element.CompareTo(node.Nodedata) < 0)
            {
                Search(element, node.leftTree);
            }
            if (element.CompareTo(node.Nodedata) > 0)
            {
                Search(element, node.rightTree);
            }
            return result;
        }
    }
}
