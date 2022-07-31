using UnityEngine;

[CreateAssetMenu(menuName = "Data/WeaponItem")]
public sealed class WeaponData : ScriptableObject
{
    public string Name; // Имя оружия
    public int Damage; //урон от 1 пули
    public int BulletsPerShot = 1; //количество пуль за один выстрел
    public float FireRate = 1f; //скорострельность
    public float ShotDistance = 100f; //дальность полета пуль
    public float BulletSpeed = 1500f; //скорость полета пули (визуал)
    public float ExplosiveRange; //радиус взрыва
    public float ExplolsionTime; //время, которое будет отображаться взрыв
}