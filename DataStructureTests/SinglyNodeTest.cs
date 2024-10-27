namespace DataStructureTests;
using DataStructures;

public class SinglyNodeTest
{
    [Fact]
    public void Should_Initialize_Node()
    {
        var node = new SinglyNode<int>(5);
        
        Assert.Equal(5, node.Value);
        Assert.Null(node.Next);
    }
}