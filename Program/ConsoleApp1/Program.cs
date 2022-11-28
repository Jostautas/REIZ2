namespace Program;

public class Program
{
    public static void Main()
    {
        Example();

    }

    public static void Example()
    {
        Tree tree = new();

        tree.AddNewNode(0); // id 1
        tree.AddNewNode(0); // id 2

        tree.AddNewNode(1); // id 3

        tree.AddNewNode(2); // id 4
        tree.AddNewNode(2); // id 5
        tree.AddNewNode(2); // id 6

        tree.AddNewNode(4); // id 7

        tree.AddNewNode(5); // id 8
        tree.AddNewNode(5); // id 9

        tree.AddNewNode(8); // id 10

        /*
                0
               / \
              1   2
             /   /|\
            3   4 5 6
               /  /\     
              7  8  9
                 |
                 10
         */


        tree.PrintTree(); // see tree connections in text

        tree.PrintDepth();
    }
}