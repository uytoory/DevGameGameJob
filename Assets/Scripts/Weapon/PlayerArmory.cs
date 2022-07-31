using UnityEngine;

public sealed class PlayerArmory : MonoBehaviour
{
    [SerializeField] Gun[] _guns;
    [SerializeField] int _currentGunIndex;

    void Start()
    {
        TakeGunByIndex(_currentGunIndex);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _currentGunIndex++;
            if (_currentGunIndex >= _guns.Length)
            {
                _currentGunIndex = 0;
            }
            TakeGunByIndex(_currentGunIndex);
        }
    }

    public void TakeGunByIndex(int gunIndex)
    {
        _currentGunIndex = gunIndex;
        for (int i = 0; i < _guns.Length; i++)
        {
            if (i == gunIndex)
            {
                _guns[i].Activate();
            }
            else
            {
                _guns[i].Deactivate();
            }
        }
    }

    public void AddBoost(int gunIndex, float damageBoost)
    {
        _guns[gunIndex].AddBoost(damageBoost);
    }
}
