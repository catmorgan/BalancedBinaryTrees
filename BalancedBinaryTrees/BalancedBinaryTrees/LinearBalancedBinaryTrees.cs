using BalancedBinaryTrees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBinaryTrees
{
    public class LinearBalancedBinaryTrees
    {
        public bool IsBinaryTreeBalanced(Node node)
        {
            if (node == null) return true;
            var leftNodeDepth = nodeDepth(node.Left);
            var rightNodeDepth = nodeDepth(node.Right);
            var depthDifference = Math.Abs(leftNodeDepth - rightNodeDepth);
            return depthDifference <= 1;
        }

        private int nodeDepth(Node node)
        {
            if (node == null) return 0;
            return 1 + Math.Max(nodeDepth(node.Left), nodeDepth(node.Right));
        }
    }
}
