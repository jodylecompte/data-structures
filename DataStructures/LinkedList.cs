namespace DataStructures;

public class LinkedList<T>
{
    public int Count = 0;
    public SinglyNode<T>? Head; 
    
    public LinkedList()
    {
    }

    public LinkedList(T value)
    {
        var node = new SinglyNode<T>(value);
        Head = node;
    }

    public SinglyNode<T> AddFirst(T value)
    {
        var node = new SinglyNode<T>(value);
        
        if (Head == null)
        {
            Head = node;
        }
        else
        {
            node.Next = Head;
            Head = node;
        }

        return node;
    }
}