using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int number;
        public Node rightLeaf;
        public Node leftLeaf;

        public Node(int value)
        {
            number = value;
            rightLeaf = null;
            leftLeaf = null;
        }

        public bool IsLeaf(ref Node node)
        {
            return (node.rightLeaf == null && node.leftLeaf == null);
        }

        public void InsertData(ref Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
            }
            else if (node.number < data)
            {
                InsertData(ref node.leftLeaf, data);
            }
            else if (node.number > data)
            {
                InsertData(ref node.rightLeaf, data);
            }
        }

        public void Display(Node n)
        {
            if (n == null)
                return;

            Display(n.leftLeaf);
            Console.Write(" " + n.number);
            Display(n.rightLeaf);
        }

        public bool Search(Node node, int s)
        {
            if (node == null)
                return false;
            if (node.number == s)
            {
                return true;
            }
            else if (node.number < s)
            {
                return Search(node.rightLeaf, s);
            }
            else if (node.number > s)
            {
                return Search(node.leftLeaf, s);
            }
            return false;
        }
    }   
}
