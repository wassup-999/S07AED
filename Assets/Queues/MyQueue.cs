using UnityEngine;

public class MyQueue <T>
{
    private QueueNode<T> head;
    private QueueNode<T> tail;
    private int count;
}
