using UnityEngine;

[CreateAssetMenu(fileName = "EntityStats", menuName = "Scriptable Objects/EntityStats")]
public class EntityStats : ScriptableObject
{
    [SerializeField] private string entityName;    
    [SerializeField] private float id;
    [SerializeField] private float speed;  
    

    public float Speed => speed;
    public float Id => id;
    public string EntityName => entityName;
}
