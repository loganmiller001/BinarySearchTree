using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bTree = new BinaryTree();


            bTree.Insert(1);
            bTree.Insert(6);
            bTree.Insert(2);
            bTree.Insert(4);
            bTree.Insert(5);
            bTree.Insert(3);

            bTree.Display();
            bTree.Search(1);

            Console.ReadLine();
        }
    }
}
