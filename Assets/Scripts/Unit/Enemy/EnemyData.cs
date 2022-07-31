using UnityEngine;
[CreateAssetMenu(menuName = "Data/EnemyList")]
public sealed class EnemyData : ScriptableObject
{
    public string Name; 
    public int Health;
    public float Experience;
    public float Speed; 
}
