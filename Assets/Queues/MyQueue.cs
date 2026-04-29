using UnityEngine;

public class MyQueue <T>
{
    #region Privates
    private QueueNode<T> head;
    private QueueNode<T> tail;
    private int count;
    #endregion
    #region Public Methods
    public void Enqueue(T value)
    {
        QueueNode<T> newNode = new(value);
        count++;
        if(head == null && tail == null)
        {
            head = newNode;
            tail = newNode;
            return;
        }
        tail.SetNext(newNode);
        tail = newNode;
    }
    public T Dequeue() 
    {
        if (head == null)
        {
            Clear();
            throw new System.Exception("Queue Empty");
        }
            
        T value = head.Value;   //primero capturar el valor de head del 1ero de la fila
        head = head.Next;

        count--;
        return value;
    }
    public T Peek()
    {
        if (head == null)
        {           
            throw new System.Exception("Queue Empty");
        }
        T value = head.Value;   
   
        return value;
    }

    public void Clear()
    {
        head = null; 
        tail = null;
        count = 0;
    }
    #endregion
    #region Getters
    public int Count => count;
    #endregion
}
