public class Rifle : Gun
{
    public override void Start()
    {
        _damage = _weapondata.Damage;
        _bulletPerShot = _weapondata.BulletsPerShot;
        _fireRate = _weapondata.FireRate;
        _shotDistance = _weapondata.ShotDistance;
        _bulletSpeed = _weapondata.BulletSpeed;
    }
}