using BinaryTree;

internal class Program
{
    private static void Main(string[] args)
    {
        Tree<int> intTree = new Tree<int>(10);
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
        string sortedData = intTree.WalkTree();
        Console.WriteLine($"Sorted data is: {sortedData}");

        Tree<string> stringTree = new Tree<string>("Hello");
        stringTree.Insert("World");
        stringTree.Insert("How");
        stringTree.Insert("Are");
        stringTree.Insert("You");
        stringTree.Insert("Today");
        stringTree.Insert("I");
        stringTree.Insert("Hope");
        stringTree.Insert("You");
        stringTree.Insert("Are");
        stringTree.Insert("Feeling");
        stringTree.Insert("Well");
        stringTree.Insert("!");
        sortedData = stringTree.WalkTree();
        Console.WriteLine($"Sorted data is: {sortedData}");
    }
}