using UnityEngine;
using UnityEngine.AI;

public class EnemyUnit : MonoBehaviour
{
    public int Health = 5;
    [SerializeField] private Player _targetUnit;
    [SerializeField] private NavMeshAgent _navMeshAgent;

    private int _maxHealth;

    [SerializeField] private GameObject _healthBarPrefab;
    private HealthBar _healthBar;

    private void Start()
    {
        _maxHealth = Health;
        GameObject healthBar = Instantiate(_healthBarPrefab);
        _healthBar = healthBar.GetComponent<HealthBar>();
        _healthBar.Setup(transform);
    }

    private void Update()
    {
        _navMeshAgent.SetDestination(_targetUnit.transform.position);
    }
    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        _healthBar.SetHealth(Health, _maxHealth);
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (_healthBar)
        {
            Destroy(_healthBar.gameObject);
        }
    }
}