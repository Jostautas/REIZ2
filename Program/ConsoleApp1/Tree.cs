namespace Program;

public class Tree
{
    private int Total { get; set; }
    private List<Node> Nodes { get; set; }

    public Tree()   // Root (0'th) node is created by default
    {
        Nodes = new List<Node>();
        Nodes.Add(new Node(0, 0));
        Total = 1;
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
                if (Nodes[j].Previous == Nodes[i].Id && Nodes[i].Id != Nodes[j].Id)
                {
                    Console.Write(Nodes[j].Id + ", ");
                }
            }
            Console.WriteLine();
        }
    }

    public void PrintDepth()
    {
        Console.WriteLine("Depth of given tree is " + GetDepth(0, 1));
    }

    public int GetDepth(int startAt, int depth)    // start search at node [startAt]
    {
        List<int> list = new();

        if(list.Count == 0)
        {
            list.Add(depth);
        }

        for (int i = 0; i < Nodes.Count; i++)
        {
            if ( Nodes[startAt].Id == Nodes[i].Previous
                && startAt != i) 
            {
                int tempDepth = GetDepth(i, depth+1);

                list.Add(tempDepth);
            }
        }
        return list.Max();
    }
}
