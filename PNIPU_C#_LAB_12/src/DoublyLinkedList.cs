using ClassLibrary;

namespace PNIPU_C__LAB_12
{
    internal class Node
    {
        public Person Data { get; set; }
        public Node? Next { get; set; }
        public Node? Previous { get; set; }

        public Node(Person data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }


    internal class DoublyLinkedList
    {
        private Node? head;
        private Node? tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void Add(Person data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                current.Data.Show();
                current = current.Next;
            }
        }

        public void InsertAfter(string name, Person newData)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Name == name)
                {
                    Node newNode = new Node(newData);
                    newNode.Next = current.Next;
                    newNode.Previous = current;
                    if (current.Next != null)
                    {
                        current.Next.Previous = newNode;
                    }
                    current.Next = newNode;
                    if (newNode.Next == null)
                    {
                        tail = newNode;
                    }
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine($"Элемент с именем {name} не найден.");
        }

        public void Clear()
        {
            while (head != null)
            {
                Node temp = head;
                head = head.Next;
                temp = null;
            }
            tail = null;
        }
    }
}
