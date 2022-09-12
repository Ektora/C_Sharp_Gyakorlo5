namespace Gyakorlo5
{
    public class Gyakorlo5
    {
        public static void Main(string[] args)
        {
            MyLinkedList ml = new MyLinkedList();
            Console.WriteLine("AddLast 58: " + ml.AddLast(58) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddFirst 12: " + ml.AddFirst(12) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddFirst 58: " + ml.AddFirst(58) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddFirst 39: " + ml.AddFirst(39) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddFirst 47: " + ml.AddFirst(47) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddFirst 58: " + ml.AddFirst(58) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddLast 17: " + ml.AddLast(17) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddFirst 26: " + ml.AddFirst(26) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddLast 58: " + ml.AddLast(58) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddFirst 95: " + ml.AddFirst(95) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddLast 31: " + ml.AddLast(31) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddLast 58: " + ml.AddLast(58) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddLast 58: " + ml.AddLast(58) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddLast 88: " + ml.AddLast(88) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddFirst 44: " + ml.AddFirst(44) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddLast 63: " + ml.AddLast(63) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddLast 58: " + ml.AddLast(58) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("AddFirst 58: " + ml.AddFirst(58) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("contains 44: " + ml.Contains(44));
            Console.WriteLine("contains 45: " + ml.Contains(45));
            Console.WriteLine("removeFirstOccurence 95: " + ml.RemoveFirstOccurrence(95) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeAll 58: " + ml.RemoveAll(58) + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeLast: " + ml.RemoveLast() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeFirst: " + ml.RemoveFirst() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeFirst: " + ml.RemoveFirst() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeLast: " + ml.RemoveLast() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeFirst: " + ml.RemoveFirst() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeFirst: " + ml.RemoveFirst() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeLast: " + ml.RemoveLast() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeLast: " + ml.RemoveLast() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeFirst: " + ml.RemoveFirst() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeLast: " + ml.RemoveLast() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeFirst: " + ml.RemoveFirst() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeFirst: " + ml.RemoveFirst() + " " + ml + " size: " + ml.Size);
            Console.WriteLine("removeLast: " + ml.RemoveLast() + " " + ml + " size: " + ml.Size);

            // Bináris kereső fa

            BinarySearchTree bst = new BinarySearchTree();
            Console.WriteLine(bst);
            Console.WriteLine("Insert 27: " + bst.Insert(27) + " " + bst);
            Console.WriteLine("Insert 48: " + bst.Insert(48) + " " + bst);
            Console.WriteLine("Insert 33: " + bst.Insert(33) + " " + bst);
            Console.WriteLine("Insert 81: " + bst.Insert(81) + " " + bst);
            Console.WriteLine("Insert 14: " + bst.Insert(14) + " " + bst);
            Console.WriteLine("Insert 48: " + bst.Insert(48) + " " + bst);
            Console.WriteLine("Insert 39: " + bst.Insert(39) + " " + bst);
            Console.WriteLine("Insert 72: " + bst.Insert(72) + " " + bst);
            Console.WriteLine(bst.Contains(33));
            Console.WriteLine(bst.Contains(32));
            Console.WriteLine("Remove 81: " + bst.Remove(81) + " " + bst);
            Console.WriteLine("Remove 48: " + bst.Remove(48) + " " + bst);
            Console.WriteLine("Remove 27: " + bst.Remove(27) + " " + bst);
            Console.WriteLine("Remove 72: " + bst.Remove(72) + " " + bst);
            Console.WriteLine("Remove 33: " + bst.Remove(33) + " " + bst);
            Console.WriteLine("Remove 44: " + bst.Remove(44) + " " + bst);
            Console.WriteLine("Remove 39: " + bst.Remove(39) + " " + bst);
            Console.WriteLine("Remove 14: " + bst.Remove(14) + " " + bst);
            Console.WriteLine("Remove 48: " + bst.Remove(48) + " " + bst);
            Console.WriteLine("Remove 27: " + bst.Remove(27) + " " + bst);


        }
    }
}