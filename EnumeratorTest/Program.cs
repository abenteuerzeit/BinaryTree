using BinaryTree;

namespace EnumeratorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> intTree = new(10);
            intTree.Insert(5);
            intTree.Insert(11);
            intTree.Insert(5);
            intTree.Insert(-12);
            intTree.Insert(15);
            intTree.Insert(0);
            intTree.Insert(14);
            intTree.Insert(-8);
            intTree.Insert(10);
            intTree.Insert(8);
            intTree.Insert(8);

            foreach (int integer in intTree)
            {
                Console.WriteLine(integer);
            }

        }
    }
}