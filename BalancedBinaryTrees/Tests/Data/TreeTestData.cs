using BalancedBinaryTrees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBinaryTrees.Tests
{
    public class TreeTestData
    {

        public Node NullTree()
        {
            return null;
        }

        /*   Tree Diagram
         *      0
         */
        public Node RootTree()
        {
            return new Node();
        }

        /*   Tree Diagram
         *      0
         *     /
         *    0
         *    
         */
        public Node OneChildTree()
        {
            var tree = new Node();
            tree.Left = new Node();
            return tree;
        }

        /*   Tree Diagram
         *      0
         *     / \
         *    0   0
         *   / \
         *  0   0
         *  
         */
        public Node EvenTreeOne()
        {
            var tree = new Node();
            tree.Left = new Node();
            tree.Right = new Node();
            tree.Left.Left = new Node();
            tree.Left.Right = new Node();
            return tree;
        }

        /*   Tree Diagram
         *      0
         *     / \
         *    0   0
         *   /   /  \
         *  0   0    0
         *     / 
         *    0
         */
        public Node EvenTreeTwo()
        {
            var tree = new Node();

            tree.Left = new Node();
            tree.Right = new Node();

            tree.Left.Left = new Node();
            tree.Right.Left = new Node();
            tree.Right.Right = new Node();

            tree.Right.Left.Left = new Node();
            return tree;
        }

        /*   Tree Diagram
         *      0
         *     / \
         *    0   0
         *   / 
         *  0
         * / 
         *0  
         * 
         */
        public Node UnevenTreeOne()
        {
            var tree = new Node();
            tree.Left = new Node();
            tree.Right = new Node();
            tree.Left.Left = new Node();
            tree.Left.Left.Left = new Node();
            return tree;
        }

        /*   Tree Diagram
         *      0
         *     / \
         *    0   0
         *   /   /  \
         *  0   0    0
         *          / \
         *         0   0
         *          \
         *           0
         *   
         * 
         */
        public Node UnevenTreeTwo()
        {
            var tree = new Node();

            tree.Left = new Node();
            tree.Right = new Node();

            tree.Left.Left = new Node();
            tree.Right.Left = new Node();
            tree.Right.Right = new Node();

            tree.Right.Right.Left = new Node();
            tree.Right.Right.Left = new Node();

            tree.Right.Right.Left.Right = new Node();
            return tree;
        }
    }
}
