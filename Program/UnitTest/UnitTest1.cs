using Xunit;
using Program;

namespace UnitTest;


public class UnitTest1
{
    [Theory]
    [MemberData(nameof(DataGetDepth5))]
    public void GetDepth5(List<int> Nodes)
    {
        Tree tree = new();

        for (int i = 0; i < Nodes.Count; i++)
        {
            tree.AddNewNode(Nodes[i]);
        }
        Assert.True(tree.GetDepth(0, 1) == 5);
    }

    public static IEnumerable<object[]> DataGetDepth5()
    {
        yield return new object[] { new List<int> { 0, 0,
                                                    1,
                                                    2, 2, 2,
                                                    4,
                                                    5, 5,
                                                    8 } };

        yield return new object[] { new List<int> { 0,
                                                    1,
                                                    2,
                                                    3, } };

        yield return new object[] { new List<int> { 0, 0, 0, 0, 0,
                                                    5,
                                                    6,
                                                    7 } };
    }

    [Theory]
    [MemberData(nameof(DataGetDepthFalse))]
    public void GetDepthFalse(List<int> Nodes)
    {
        Tree tree = new();

        for (int i = 0; i < Nodes.Count; i++)
        {
            tree.AddNewNode(Nodes[i]);
        }
        Assert.False(tree.GetDepth(0, 1) == 5);
    }

    public static IEnumerable<object[]> DataGetDepthFalse()
    {
        yield return new object[] { new List<int> { 0, 0,
                                                    1,
                                                    2, 2, 2,
                                                    4,
                                                    5, 5 } };

        yield return new object[] { new List<int> { 0,
                                                    1,
                                                    2,
                                                    3,
                                                    4 } };
    }
}