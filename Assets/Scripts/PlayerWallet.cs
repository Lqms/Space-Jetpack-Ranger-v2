using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private float _money;

    public event UnityAction<float> MoneyChanged;

    public void Initialize(float money)
    {
        _money = money;
    }

    public void AddMoney(float value)
    {
        _money += value;
        MoneyChanged?.Invoke(_money);
    }

    public bool TrySpendMoney(float value)
    {
        if (_money >= value)
        {
            _money -= value;
            MoneyChanged?.Invoke(_money);
        }

        return _money >= value;
    }
}
