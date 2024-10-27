namespace DataStructureTests;

public class LinkedListTest
{
    [Fact]
    public void Should_Initialize_Empty_On_Default_Constructor()
    {
        var list = new DataStructures.LinkedList<int>();
        Assert.Null(list.Head);
    }

    [Fact]
    public void Should_Initialize_With_Head_On_Single_Value()
    {
        var list = new DataStructures.LinkedList<int>(5);
        Assert.NotNull(list.Head);
        Assert.Equal(5, list.Head.Value);
    }

    [Fact]
    public void AddFirst_Should_Establish_Head()
    {
        var list = new DataStructures.LinkedList<int>();
        Assert.Null(list.Head);

        list.AddFirst(5);
        
        Assert.NotNull(list.Head);
        Assert.Equal(5, list.Head.Value);
    }

    [Fact]
    public void AddFirst_Should_Append_New_Head()
    {
        var list = new DataStructures.LinkedList<int>(10);
        list.AddFirst(5);
        
        Assert.NotNull(list.Head);
        Assert.NotNull(list.Head.Next);
        
        Assert.Equal(5, list.Head.Value);
        Assert.Equal(10, list.Head.Next.Value);
    }
}