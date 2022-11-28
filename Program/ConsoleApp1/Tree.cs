namespace Program;

public class Tree
{
    private int Total { get; set; }
    private List<Node> Nodes { get; set; }

    public Tree()
    {
        Total = 0;
        Nodes = new List<Node>();
    }

    public void AddNewNode(int addTo)
    {
        Nodes.Add(new Node(Total, addTo));
        ++Total;
    }

    public void PrintTree()
    {
        for(int i = 0; i < Nodes.Count; i++)
        {
            Console.Write(Nodes[i].Id + ": ");

            for(int j = 0; j < Nodes.Count; j++)
            {
                if (Nodes[j].Previous == Nodes[i].Id)
                {
                    Console.Write(Nodes[j].Id + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
