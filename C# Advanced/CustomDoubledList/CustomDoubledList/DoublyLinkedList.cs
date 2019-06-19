using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomDoubledList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private class ListNode
        {
            public T Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }

            public ListNode(T value)
            {
                Value = value;
            }
        }
        private ListNode head;
        private ListNode tail;
        public int Count { get;private set; }

        public void AddFirst(T value)
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

        public void AddLast(T value)
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
        public T RemoveFirst()
        {
            CheckIfEmpty();
            T element = head.Value;
            ListNode currentHead = head;
            head = currentHead.NextNode;
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
        public T RemoveLast()
        {
            CheckIfEmpty();
            T element = tail.Value;
            ListNode currentTail = tail;
            tail = currentTail.PreviousNode;

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

        public void ForEach(Action<T> action)
        {
            var currentHead = head;
            while (currentHead != null)
            {
                action(currentHead.Value);
                currentHead = currentHead.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] arr = new T[Count];
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

        public IEnumerator<T> GetEnumerator()
        {
            return IternalNumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator<T> IternalNumerator()
        {
            ListNode currentHead = head;
            while (currentHead != null)
            {
                yield return currentHead.Value;
                currentHead = currentHead.NextNode;
            }
        }
    }
}
