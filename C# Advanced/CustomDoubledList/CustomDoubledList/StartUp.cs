using System;

namespace CustomDoubledList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddFirst(2);
            doublyLinkedList.AddLast(3);
            doublyLinkedList.AddLast(4);
            doublyLinkedList.RemoveFirst();
            doublyLinkedList.RemoveLast();

            doublyLinkedList.ForEach(Console.WriteLine);
            Console.WriteLine(string.Join(" ",doublyLinkedList.ToArray()));

            doublyLinkedList.RemoveFirst();
            doublyLinkedList.RemoveLast();
        }
    }
}
