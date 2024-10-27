namespace DataStructures;

public class SinglyNode<T>
{
    public T Value { get; set; }
    public SinglyNode<T>? Next { get; set; }

    public SinglyNode(T data)
    {
        Value = data;
        Next = null;
    }
}