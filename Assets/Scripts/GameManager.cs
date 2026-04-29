using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    public MyQueue<string> BankQueue = new();

    public float speed = 0;
    public float MaxSpeed = 100;
    void Start()
    {
        
    }
    private void Update()
    {
        //speed = Mathf.Lerp(speed, MaxSpeed, Time.deltaTime);

        speed = Mathf.PingPong(Time.time * 1.5f, 5);

        transform.position = new Vector3(speed, 0, speed);




      
    }

    [Button]
    public void TestMathf()
    {
        Debug.Log(Mathf.Clamp(speed,-100,100));
        Debug.Log(Mathf.Clamp01(-1000));

        Debug.Log(Mathf.Abs(-20)) ;
        Debug.Log(Mathf.Min(10,30));
        Debug.Log(Mathf.Max(10, 30));
        Debug.Log(Mathf.Round(5.2f));//-> 5
        Debug.Log(Mathf.Floor(5.99999f));//->5
        Debug.Log(Mathf.Ceil(5.0000001f));//->6
        Debug.Log(Mathf.Sqrt(25)); //-> 5
        Debug.Log(Mathf.Pow(2,3)); //-> 8   2*2*2
    }





    [Button]
    public void Enqueue(string name)
    {
        BankQueue.Enqueue(name);
    }
    [Button]
    public void Dequeue()
    {
       Debug.Log("Pase a ser atendido : " +  BankQueue.Dequeue());
    }
    [Button]
    public void Peek()
    {
        Debug.Log("El siguiente en ser atendido sera ... " + BankQueue.Peek());
    }

    [Button]
    public void Clear()
    {
        BankQueue.Clear();  
    }

    [Button]
    public void Count()
    {
        Debug.Log( BankQueue.Count);
    }



}
