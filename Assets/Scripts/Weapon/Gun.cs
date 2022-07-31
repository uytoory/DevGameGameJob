using UnityEngine;
using UnityEngine.EventSystems;

public class Gun : MonoBehaviour
{
    [SerializeField] private EnemyUnit _enemyUnit;
    [SerializeField] protected WeaponData _weapondata;
    [SerializeField] protected GameObject _bulletPrefab;
    [SerializeField] protected float _bulletSpeed;
    [SerializeField] protected float _fireRate;
    [SerializeField] protected float _shotDistance;
    [SerializeField] protected int _bulletPerShot;
    [SerializeField] protected int _damage;

    [SerializeField] protected Transform _spawn;
    [SerializeField] protected AudioSource _shotSound;
    [SerializeField] protected GameObject _flash;

    private GameObject newBullet;
    private float _timer;

    virtual public void Start() { }

    public virtual void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 1 / _fireRate)
        {
            if (Input.GetMouseButton(0))
            {
                if (!EventSystem.current.IsPointerOverGameObject())
                {
                    _timer = 0f;
                    Shot();
                }
            }
        }
    }

    public virtual void Shot()
    {
        newBullet = Instantiate(_bulletPrefab, _spawn.position, _spawn.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = _spawn.forward * _bulletSpeed;
        if (newBullet)
        _shotSound.Play();
        _flash.SetActive(true);
        Invoke(nameof(HideFlash), 0.10f);
    }

    public void HideFlash()
    {
        _flash.SetActive(false);
    }

    public virtual void Activate()
    {
        gameObject.SetActive(true);
    }
    public virtual void Deactivate()
    {
        gameObject.SetActive(false);
    }
    public virtual void AddBoost(float damageBoost) { }
}