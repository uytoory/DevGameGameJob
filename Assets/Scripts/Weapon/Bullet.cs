using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public sealed class Bullet : MonoBehaviour
{
    [SerializeField] GameObject _effectPrefab;
    [SerializeField] EnemyUnit _enemyUnit;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.GetComponent<Bullet>())
        {
            Instantiate(_effectPrefab, transform.position, Quaternion.identity);
            if ( collision.rigidbody.GetComponent<EnemyUnit>())
            {
                _enemyUnit.TakeDamage(1);
                Debug.Log("123");
            }
            Destroy(gameObject);
        }
    }
}