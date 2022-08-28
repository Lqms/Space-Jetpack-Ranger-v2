using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _baseDamage = 50;
    [SerializeField] private float _baseHealth = 100;
    [SerializeField] private float _baseEnergy = 100;

    private float _damage;
    private float _health;
    private float _energy;

    private void OnEnable()
    {
        _damage = _baseDamage + PlayerPrefs.GetFloat(StringConsts.Damage.ToString());
        _health = _baseHealth + PlayerPrefs.GetFloat(StringConsts.Health.ToString());
        _energy = _baseEnergy + PlayerPrefs.GetFloat(StringConsts.Energy.ToString());
    }
}
