using System;

namespace CustomDoubledList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> doublyLinkedList = new DoublyLinkedList<string>();

            doublyLinkedList.AddFirst("obicham");
            doublyLinkedList.AddFirst("az");
            doublyLinkedList.AddLast("luti");
            doublyLinkedList.AddLast("chushki");

            foreach (var item in doublyLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
