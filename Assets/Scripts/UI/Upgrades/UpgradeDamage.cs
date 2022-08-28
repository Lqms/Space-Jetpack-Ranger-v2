using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UpgradeDamage : MonoBehaviour, IUpgrade
{
    [SerializeField] private float _extraDamage;

    private float _damage;

    public event UnityAction<float> DamageIncreased;

    public void Initialize(float damage)
    {
        _damage = damage;
    }

    public void Apply()
    {
        _damage += _extraDamage;
        DamageIncreased?.Invoke(_damage);
    }
}
