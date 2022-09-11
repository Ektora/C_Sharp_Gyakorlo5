using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class MyLinkedList
    {
        public int Size { get; private set; }

        Node Head { get; set; }

        class Node
        {
            public int Value { get; private set; }
            public Node Next { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Value);
                if (Next != null)
                {
                    sb.Append(" ").Append(Next);
                }
                return sb.ToString();
            }

            public Node(int val)
            {
                Value = val;
            }
        }

        public bool IsEmpty()
        {
            // Write your code here
        }

        public bool AddFirst(int val)
        {
            // Write your code here
        }

        public bool AddLast(int val)
        {
            // Write your code here
        }

        public bool RemoveFirst()
        {
            // Write your code here
        }

        public bool RemoveLast()
        {
            // Write your code here
        }

        public bool RemoveFirstOccurrence(int val)
        {
            // Write your code here
        }

        public bool RemoveAll(int val)
        {
            // Write your code here
        }

        public bool Contains(int val)
        {
            // Write your code here
        }

        public override string ToString()
        {
            return Head == null ? String.Empty : Head.ToString();
        }
    }
}