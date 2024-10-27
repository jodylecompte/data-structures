namespace DataStructureTests;
using DataStructures;

public class DoublyNodeTest
{
    [Fact]
    public void Should_Initialize_Node()
    {
        var node = new DoublyNode<int>(5);
        
        Assert.Equal(5, node.Value);
        Assert.Null(node.Next);
        Assert.Null(node.Previous);
    }
}