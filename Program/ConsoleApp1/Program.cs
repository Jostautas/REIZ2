namespace Program;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("hi");

        Tree tree = new();

        tree.AddNewNode(0);
        tree.AddNewNode(0);
        tree.AddNewNode(0);
        tree.AddNewNode(1);
        tree.AddNewNode(1);

        tree.PrintTree();

    }
}
