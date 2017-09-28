using BalancedBinaryTrees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BalancedBinaryTrees.Tests
{
    public class LinearBalancedBinaryTreesUnitTests
    {
        private readonly TreeTestData data;
        public LinearBalancedBinaryTreesUnitTests()
        {
            data = new TreeTestData();
        }

        [Fact]
        public void LinearTree_IsBinaryTreeBalanced_NullRoot_True()
        {
            var linearBalancedTree = new LinearBalancedBinaryTrees();

            Assert.True(linearBalancedTree.IsBinaryTreeBalanced(data.NullTree()));
        }

        [Fact]
        public void LinearTree_IsBinaryTreeBalanced_Root_True()
        {
            var linearBalancedTree = new LinearBalancedBinaryTrees();

            Assert.True(linearBalancedTree.IsBinaryTreeBalanced(data.RootTree()));
        }

        [Fact]
        public void LinearTree_IsBinaryTreeBalanced_OnlyOneChild_True()
        {
            var linearBalancedTree = new LinearBalancedBinaryTrees();

            Assert.True(linearBalancedTree.IsBinaryTreeBalanced(data.OneChildTree()));
        }

        [Fact]
        public void LinearTree_IsBinaryTreeBalanced_EvenTreeOne_True()
        {
            var linearBalancedTree = new LinearBalancedBinaryTrees();

            Assert.True(linearBalancedTree.IsBinaryTreeBalanced(data.EvenTreeOne()));
        }

        [Fact]
        public void LinearTree_IsBinaryTreeBalanced_EvenTreeTwo_True()
        {
            var linearBalancedTree = new LinearBalancedBinaryTrees();
            var tree = new Node();

            Assert.True(linearBalancedTree.IsBinaryTreeBalanced(data.EvenTreeTwo()));
        }

        [Fact]
        public void LinearTree_IsBinaryTreeBalanced_UnevenTreeOne_False()
        {
            var linearBalancedTree = new LinearBalancedBinaryTrees();

            Assert.False(linearBalancedTree.IsBinaryTreeBalanced(data.UnevenTreeOne()));
        }

        [Fact]
        public void LinearTree_IsBinaryTreeBalanced_UnevenTreeTwo_False()
        {
            var linearBalancedTree = new LinearBalancedBinaryTrees();

            Assert.False(linearBalancedTree.IsBinaryTreeBalanced(data.UnevenTreeTwo()));
        }
    }
}
