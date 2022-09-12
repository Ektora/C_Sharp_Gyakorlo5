using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo5
{
    class BinarySearchTree
    {
        Node Root { get; set; }

        class Node
        {

            public int Key { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int key)
            {
                Key = key;
                Left = Right = null;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                if (Left != null)
                {
                    sb.Append(Left).Append(" ");
                }
                sb.Append(Key);
                if (Right != null)
                {
                    sb.Append(" ").Append(Right);
                }
                sb.Append(")");
                return sb.ToString();
            }
        }

        public bool Insert(int key)
        {
            if(Root == null)
            {
                Root = new Node(key);
                return true;
            }
            else
            {
                Node seged = Root;
                while(seged != null)
                {
                    if(seged.Key < key)
                    {
                        if(seged.Right == null)
                        {
                            seged.Right = new Node(key);
                            return true;
                        }
                        seged = seged.Right;
                    }
                    else if(seged.Key > key)
                    {
                        if (seged.Left == null)
                        {
                            seged.Left = new Node(key);
                            return true;
                        }
                        seged = seged.Left;
                    }
                    else
                        return false;
                }
            }
            return false;
        }

        public bool Remove(int key)
        {
            if (!Contains(key))
            {
                return false;
            }
            Node seged = Root;
            Node parent = null;
            while(seged.Key != key)
              {
                if (seged.Key < key)
                {
                    parent = seged;
                    seged = seged.Right;
                }
                else if (seged.Key > key)
                {
                    parent = seged;
                    seged = seged.Left;
                }
              }
            if (seged.Left == null && seged.Right == null && parent != null)
            {
                if(parent.Key > key)
                {
                    parent.Left = null;
                    return true;
                }
                else
                {
                    parent.Right = null;
                    return true;
                }
            }
            else if (seged.Left != null && seged.Right == null && parent != null)
            {
                if (parent.Key < key)
                {
                    parent.Right = seged.Left;
                    return true;
                }
                else
                {
                    parent.Left = seged.Right;
                    return true;
                }
            }
            else if (seged.Left == null && seged.Right != null && parent != null)
            {
                if (parent.Key > key)
                {
                    parent.Left = seged.Right;
                    return true;
                }
                else
                {
                    parent.Right = seged.Left;
                    return true;
                }
            }
            else if(seged.Left != null && seged.Right != null && parent != null)
            {
                Console.WriteLine(parent.Key + " " + seged.Key);
                Node seged2 = seged.Right;
                Node parent2 = seged.Right;
                while(seged2.Left != null)
                {
                    parent2 = seged2;
                    seged2 = seged2.Left;
                }
                seged.Key = seged2.Key;
                
                return true;
            }
            return false;
        }

        public bool Contains(int key)
        {
            if (Root == null)
                return false;
            Node seged = Root;
            while(seged != null)
            {
                if (seged.Key == key)
                    return true;
                else if(seged.Key < key)
                {
                    seged = seged.Right;
                }
                else if(seged.Key > key)
                {
                    seged = seged.Left;
                }
            }
            return false;
        }

        public override String ToString()
        {
            return Root == null ? String.Empty : Root.ToString();
        }
    }
}
