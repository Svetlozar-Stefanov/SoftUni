using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoubledList
{
    public class DoublyLinkedList
    {
        private class ListNode
        {
            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }

            public ListNode(int value)
            {
                Value = value;
            }
        }
        private ListNode head;
        private ListNode tail;
        public int Count { get;private set; }

        public void AddFirst(int value)
        {
            if (Count == 0)
            {
                head = tail = new ListNode(value);
            }
            else
            {
                ListNode newHead = new ListNode(value);
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }
            Count++;
        }

        public void AddLast(int value)
        {
            if (Count == 0)
            {
                head = tail = new ListNode(value);
            }
            else
            {
                ListNode newTail = new ListNode(value);
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }
            Count++;
        }
        public int RemoveFirst()
        {
            CheckIfEmpty();
            int element = head.Value;
            head = head.NextNode;
            if (head != null)
            {
                head.PreviousNode = null;
            }
            else
            {
                tail = null;
            }
            Count--;
            return element;
        }
        public int RemoveLast()
        {
            CheckIfEmpty();
            int element = tail.Value;

            tail = tail.PreviousNode;
            if (tail != null)
            {
                tail.NextNode = null;
            }
            else
            {
                head = null;
            }
            Count--;
            return element;
        }

        public void ForEach(Action<int> action)
        {
            var currentHead = head;
            while (currentHead != null)
            {
                action(currentHead.Value);
                currentHead = currentHead.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] arr = new int[Count];
            int counter = 0;
            var cuurentNode = head;
            while (cuurentNode != null)
            {
                arr[counter] = cuurentNode.Value;
                cuurentNode = cuurentNode.NextNode;
                counter++;
            }
            return arr;
        }
        private void CheckIfEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
