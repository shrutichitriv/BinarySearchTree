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
    }
}
