namespace DataStructures;

public class DoublyNode<T>
{
    public T Value { get; set; }
    public DoublyNode<T>? Next { get; set; }
    public DoublyNode<T>? Previous { get; set; }

    public DoublyNode(T data)
    {
        Value = data;
        Next = null;
        Previous = null;
    }
}