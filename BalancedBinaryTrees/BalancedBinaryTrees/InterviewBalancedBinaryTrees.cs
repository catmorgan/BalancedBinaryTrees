using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalancedBinaryTrees.Models;

namespace BalancedBinaryTrees
{
    public class InterviewBalancedBinaryTrees
    {
        /*
         * This code was never going to work because this is counting how many nodes are on each side starting from the root; it was
         * not counting the depth. For instance, it would think the following tree is not balanced, when it is.
         *              0
         *            /   \
         *           0     0
         *          / \      
         *         0   0      
         *
         * This is proved by the failing test in Tests -> InterviewBalancedBinaryTreeUnitTests.cs ->  InterviewTree_IsBinaryTreeBalanced_EvenTreeOne_True()
         * I realized this is because I did not take the max height between the left and right subtrees.
         * 
         * After researching binary trees, I have implemented the correct linear solution. 
         * 
         */

        public bool IsBinaryTreeBalanced(Node root)
        {
            if (root == null) return true;

            var leftDepth = 0;
            var rightDepth = 0;
            recurseBinaryTree(root.Left, ref leftDepth);
            recurseBinaryTree(root.Right, ref rightDepth);
            var depthDifference = Math.Abs(leftDepth - rightDepth);
            return depthDifference <= 1;
        }

        private void recurseBinaryTree(Node node, ref int depth)
        {
            if (node == null) return; 
            depth++;

            if (node.Left == null && node.Right == null) return;

            if (node.Left != null)
            {
                recurseBinaryTree(node.Left, ref depth);
            }
            if (node.Right != null)
            {
                recurseBinaryTree(node.Right, ref depth);
            }
        }
    }
}
