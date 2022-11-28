namespace Program;

public class Node
{
    public int Id { get; set; }
    public int Previous { get; set; }

    public Node(int count, int addTo)
    {
        Id = count;
        Previous = addTo;
    }
}
