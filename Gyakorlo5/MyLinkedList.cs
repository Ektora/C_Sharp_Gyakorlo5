using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo5
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
            if (Size == 0)
                return true;
            return false;
        }

        public bool AddFirst(int val)
        {
            if(IsEmpty())
            {
                Head = new Node(val);
            }
            else
            {
                Node uj = new Node(val);
                uj.Next = Head;
                Head = uj;
            }
            Size++;
            return true;
        }

        public bool AddLast(int val)
        {
            if (IsEmpty())
            {
                Head = new Node(val);
            }
            else
            {
                Node seged = Head;
                while (seged.Next != null)
                {
                    seged = seged.Next;
                }
                seged.Next = new Node(val);
            }
            Size++;
            return true;
        }

        public bool RemoveFirst()
        {
            if (IsEmpty())
            {
                return false;
            }
            else if (Size == 1)
            {
                Head = null;
                Size = 0;
                return true;
            }
            else
            {
                Head = Head.Next;
                Size--;
            }
            return true;
        }

        public bool RemoveLast()
        {
            if (IsEmpty())
            {
                return false;
            }
            else if (Size == 1)
            {
                Head = null;
                Size = 0;
                return true;
            }
            else
            {
                Node seged = Head;
                while (seged.Next.Next != null)
                {
                    seged = seged.Next;
                }
                seged.Next = null;
                Size--;
            }
            return true;
        }

        public bool RemoveFirstOccurrence(int val)
        {
            if (IsEmpty() || !Contains(val))
            {
                return false;
            }
            else if(Head.Value == val)
            {
                RemoveFirst();
            }
            else
            {
                Node seged = Head;
                while(seged.Next != null)
                {
                    if(seged.Next.Value == val)
                    {
                        seged.Next = seged.Next.Next;
                        Size--;
                        return true;
                    }
                    seged = seged.Next;
                }
                
                
            }
            return true;
        }

        public bool RemoveAll(int val)
        {
            if (IsEmpty() || !Contains(val))
            {
                return false;
            }
            else
            {
                while (Contains(val))
                {
                    RemoveFirstOccurrence(val);
                }
            }
            return true;
        }

        public bool Contains(int val)
        {
            if (IsEmpty())
            {
                return false;
            }
            else
            {
                Node seged = Head;
                while(seged != null)
                {
                    if (seged.Value == val)
                        return true;
                    seged = seged.Next;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return Head == null ? String.Empty : Head.ToString();
        }
    }
}