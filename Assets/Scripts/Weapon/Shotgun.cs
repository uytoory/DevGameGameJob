using UnityEngine;

public class Shotgun : Gun
{
    public override void Start()
    {
        _damage = _weapondata.Damage;
        _bulletPerShot = _weapondata.BulletsPerShot;
        _fireRate = _weapondata.FireRate;
        _shotDistance = _weapondata.ShotDistance;
        _bulletSpeed = _weapondata.BulletSpeed;
    }

    public override void Shot()
    {
        for (int i = 0; i < _bulletPerShot; i++)
        {
            GameObject newBullet = Instantiate(_bulletPrefab, _spawn.position /*+ new Vector3(Random.Range(0f, 0.2f), Random.Range(-0.2f, 0.2f), 0f)*/, Quaternion.identity);
            newBullet.GetComponent<Rigidbody>().velocity = _spawn.forward * _bulletSpeed;

            Destroy(newBullet, _shotDistance / _bulletSpeed);
        }
        _shotSound.Play();
        _flash.SetActive(true);
        Invoke(nameof(HideFlash), 0.10f);
    }
}