using BalancedBinaryTrees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace BalancedBinaryTrees.Tests
{
    public class InterviewBalancedBinaryTreesUnitTests
    {
        private readonly TreeTestData data;
        public InterviewBalancedBinaryTreesUnitTests()
        {
            data = new TreeTestData();
        }

        [Fact]
        public void InterviewTree_IsBinaryTreeBalanced_NullRoot_True()
        {
            var interviewBalancedTree = new InterviewBalancedBinaryTrees();
            Assert.True(interviewBalancedTree.IsBinaryTreeBalanced(data.NullTree()));
        }

        [Fact]
        public void InterviewTree_IsBinaryTreeBalanced_Root_True()
        {
            var interviewBalancedTree = new InterviewBalancedBinaryTrees();
            
            Assert.True(interviewBalancedTree.IsBinaryTreeBalanced(data.RootTree()));
        }

        [Fact]
        public void InterviewTree_IsBinaryTreeBalanced_OnlyOneChild_True()
        {
            var interviewBalancedTree = new InterviewBalancedBinaryTrees();

            Assert.True(interviewBalancedTree.IsBinaryTreeBalanced(data.OneChildTree()));
        }
        
        [Fact]
        public void InterviewTree_IsBinaryTreeBalanced_EvenTreeOne_True()
        {
            var interviewBalancedTree = new InterviewBalancedBinaryTrees();

            Assert.True(interviewBalancedTree.IsBinaryTreeBalanced(data.EvenTreeOne()));
        }
    }
}
