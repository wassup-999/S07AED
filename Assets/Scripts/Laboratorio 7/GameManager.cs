using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MyQueue<string> BankQueue = new();

    /*
    public float speed = 0;
    public float Maxspeed = 100;
    */
    public PriorityQueue<EntityStats> priorityQueueSpeed = new((a, b) => a.Speed > b.Speed);

    public PriorityQueue<EntityStats> priorityQueueID = new((a, b) => a.Id < b.Id);

    void Start()
    {
        
    }
    private void Update()
    {
        /*
        speed = Mathf.PingPong(Time.time * 0.5f , 5); // para que se mueva de un lado a otro y regrese
        transform.position = new Vector3(speed , 0 , 0);
        //speed = Mathf.Lerp(speed, Maxspeed, Time.deltaTime); /// Mover un valor de un minimo y maximo
        */
    }
    /*
    [Button]
    public void TestMathf()
    {
       Debug.Log(Mathf.Clamp(1000, 0, 1));
       
       Mathf.Abs(-20); // combierte valores de negativo a positivo

       Mathf.Max(10, 40); // retorna valor maximo
       Mathf.Min(10, 40); // retorna valor minimo
        
       Mathf.Round(5.5f); // redondea el valor
       Mathf.Floor(4.999f); // retorna el valor más abajo -> 4
       Mathf.Ceil(6.4f); // retorn valor más alto -> 7

    }
    */


    [Button]
    public void AddToQueue(EntityStats entity)
    {
        priorityQueueSpeed.Enqueue(entity);
    }
    [Button]
    public void DeQueue()
    {
        Debug.Log("Pase a ser atendido : " + priorityQueueSpeed.Dequeue());
    }
    [Button]
    public void Peek()
    {
        Debug.Log("Atendiendo turno : " + priorityQueueSpeed.Peek());
    }
    [Button]
    public void Clear()
    {
        priorityQueueSpeed.Clear();
    }
    /*
    public MyStack<string> nameStack = new();

     void Start()
    {
        
    }

    [Button]
    public void PushToStack(string value)
    {
        nameStack.Push(value);
    }
    [Button]
    public void PopFromStack()
    {
       Debug.Log(nameStack.Pop());
    }
    [Button]
    public void PeekFromStack()
    {
        Debug.Log(nameStack.Peek());
    }
    [Button]
    public void ClearStack()
    {
       nameStack.Clear();   
    }
    [Button]
    public void Count() => Debug.Log(nameStack.Count);

    */
}
