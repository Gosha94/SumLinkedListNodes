using System;

namespace SumLinkedListNodes.ConsoleApp.Models
{

    /// <summary>
    /// Класс описывает простейший связный список
    /// </summary>
    public class CustomLinkedList
    {
        public ListNode HeadOfFirstList { get; set; }
        public ListNode HeadOfSecondList { get; set; }

        /// <summary>
        /// Метод сложения двух связных списков
        /// </summary>
        /// <param name="firstNode"></param>
        /// <param name="secondNode"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode firstNode, ListNode secondNode)
        {
            ListNode headOfResultLinkedList, previousNode, tempNode;
            headOfResultLinkedList = previousNode = tempNode = null;

            int restInMind = 0, numberSum;
            
            while (firstNode != null || secondNode != null)
            {
                numberSum =
                    restInMind
                    + (firstNode != null ? firstNode.Value : 0)
                    + (secondNode != null ? secondNode.Value : 0);

                restInMind = (numberSum >= 10) ? 1 : 0;
                numberSum %= 10;

                tempNode = new ListNode(numberSum);
                
                if (headOfResultLinkedList == null)
                {
                    headOfResultLinkedList = tempNode;
                }
                else
                {
                    previousNode.Next = tempNode;
                }

                previousNode = tempNode;
                
                if (firstNode != null)
                {
                    firstNode = firstNode.Next;
                }
                if (secondNode != null)
                {
                    secondNode = secondNode.Next;
                }
            }

            if (restInMind > 0)
            {
                tempNode.Next = new ListNode(restInMind);
            }

            return headOfResultLinkedList;
        }
    }
}