using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {

        public Node root;
        public int count;
        

        public BinaryTree()
        {
            root = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Insert(int d)
        {
            if (IsEmpty())
            {
                root = new Node(d);
            }
            else
            {
                root.InsertData(ref root, d);
            }
            count++;
        }

        public bool Search(int s)
        {
            return root.Search(root, s);
        }
        
        public bool IsLeaf()
        {
            if (!IsEmpty())
                return root.IsLeaf(ref root);
            return true;
        }

        public void Display()
        {
            if (IsEmpty())
                root.Display(root);
        }
        public int Count()
        {
            return count;
        }
    }

}
