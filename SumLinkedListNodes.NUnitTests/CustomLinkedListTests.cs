using NUnit.Framework;
using SumLinkedListNodes.ConsoleApp.Models;

namespace SumLinkedListNodes.NUnitTests
{
    public class CustomLinkedListTests
    {
        private CustomLinkedList actualListUnderTests;
        private CustomLinkedList expectedListUnderTests;

        [SetUp]
        public void Setup()
        {
            PrepareDataForTests();
        }

        [Test]
        public void AddTwoNumbersMethod_ReturnsCorrectLinkedList()
        {
            // Arrange
            PrepareTwoLinkedLists();

            expectedListUnderTests.HeadOfFirstList = new ListNode(3);
            expectedListUnderTests.HeadOfFirstList.Next = new ListNode(5);
            expectedListUnderTests.HeadOfFirstList.Next.Next = new ListNode();
            expectedListUnderTests.HeadOfFirstList.Next.Next.Next = new ListNode(7);
            expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Next = new ListNode(8);
            expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Next.Next = new ListNode(9);

            // Act
            var headOfResultLinkedList = actualListUnderTests.AddTwoNumbers(actualListUnderTests.HeadOfFirstList, actualListUnderTests.HeadOfSecondList);

            // Assert
            var conditionOfPass =
                headOfResultLinkedList.Value == expectedListUnderTests.HeadOfFirstList.Value
                &&
                headOfResultLinkedList.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Value
                &&
                headOfResultLinkedList.Next.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Next.Value
                &&
                headOfResultLinkedList.Next.Next.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Value
                &&
                headOfResultLinkedList.Next.Next.Next.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Next.Value
                &&
                headOfResultLinkedList.Next.Next.Next.Next.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Next.Next.Value;

            Assert.IsTrue(conditionOfPass);
        }
        
        [Test]
        public void AddTwoNumbersMethod_FirstListIsEmpty_ReturnsSecondList()
        {
            // Arrange
            PrepareTwoLinkedLists();

            actualListUnderTests.HeadOfFirstList = new ListNode();

            expectedListUnderTests.HeadOfSecondList = new ListNode(2);
            expectedListUnderTests.HeadOfSecondList.Next = new ListNode();
            expectedListUnderTests.HeadOfSecondList.Next.Next = new ListNode(5);


            // Act
            var headOfResultLinkedList = actualListUnderTests.AddTwoNumbers(actualListUnderTests.HeadOfFirstList, actualListUnderTests.HeadOfSecondList);

            // Assert
            var conditionOfPass =
                headOfResultLinkedList.Value == expectedListUnderTests.HeadOfSecondList.Value
                &&
                headOfResultLinkedList.Next.Value == expectedListUnderTests.HeadOfSecondList.Next.Value
                &&
                headOfResultLinkedList.Next.Next.Value == expectedListUnderTests.HeadOfSecondList.Next.Next.Value;

            Assert.IsTrue(conditionOfPass);
        }

        [Test]
        public void AddTwoNumbersMethod_SecondListIsEmpty_ReturnsFirstList()
        {
            // Arrange
            PrepareTwoLinkedLists();

            actualListUnderTests.HeadOfSecondList = new ListNode();

            expectedListUnderTests.HeadOfFirstList = new ListNode(1);
            expectedListUnderTests.HeadOfFirstList.Next = new ListNode(5);
            expectedListUnderTests.HeadOfFirstList.Next.Next = new ListNode(5);
            expectedListUnderTests.HeadOfFirstList.Next.Next.Next = new ListNode(6);
            expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Next = new ListNode(8);
            expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Next.Next = new ListNode(9);

            // Act
            var headOfResultLinkedList = actualListUnderTests.AddTwoNumbers(actualListUnderTests.HeadOfFirstList, actualListUnderTests.HeadOfSecondList);

            // Assert
            var conditionOfPass =
                headOfResultLinkedList.Value == expectedListUnderTests.HeadOfFirstList.Value
                &&
                headOfResultLinkedList.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Value
                &&
                headOfResultLinkedList.Next.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Next.Value
                &&
                headOfResultLinkedList.Next.Next.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Value
                &&
                headOfResultLinkedList.Next.Next.Next.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Next.Value
                &&
                headOfResultLinkedList.Next.Next.Next.Next.Next.Value == expectedListUnderTests.HeadOfFirstList.Next.Next.Next.Next.Next.Value;

            Assert.IsTrue(conditionOfPass);
        }

        [Test]
        public void AddTwoNumbersMethod_BothListsIsEmpty_ReturnsZeroInHeadNode()
        {
            // Arrange
            ClearBothLists();

            this.expectedListUnderTests.HeadOfFirstList = new ListNode();

            // Act
            var headOfResultLinkedList = actualListUnderTests.AddTwoNumbers(actualListUnderTests.HeadOfFirstList, actualListUnderTests.HeadOfSecondList);

            // Assert
            var conditionOfPass =
                headOfResultLinkedList.Value == expectedListUnderTests.HeadOfFirstList.Value;

            Assert.IsTrue(conditionOfPass);
        }

        #region Private Heplers Methods

        private void ClearBothLists()
        {
            this.actualListUnderTests.HeadOfFirstList = new ListNode();
            this.actualListUnderTests.HeadOfSecondList = new ListNode();

            this.expectedListUnderTests.HeadOfFirstList = new ListNode();
            this.expectedListUnderTests.HeadOfSecondList = new ListNode();
        }

        private void PrepareDataForTests()
        {
            this.actualListUnderTests = new CustomLinkedList();
            this.expectedListUnderTests = new CustomLinkedList();
        }

        private void PrepareTwoLinkedLists()
        {
            actualListUnderTests.HeadOfFirstList = new ListNode(1);
            actualListUnderTests.HeadOfFirstList.Next = new ListNode(5);
            actualListUnderTests.HeadOfFirstList.Next.Next = new ListNode(5);
            actualListUnderTests.HeadOfFirstList.Next.Next.Next = new ListNode(6);
            actualListUnderTests.HeadOfFirstList.Next.Next.Next.Next = new ListNode(8);
            actualListUnderTests.HeadOfFirstList.Next.Next.Next.Next.Next = new ListNode(9);

            actualListUnderTests.HeadOfSecondList = new ListNode(2);
            actualListUnderTests.HeadOfSecondList.Next = new ListNode();
            actualListUnderTests.HeadOfSecondList.Next.Next = new ListNode(5);
        }

        #endregion

    }
}