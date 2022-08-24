using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _damage;

    public void Initialize(float damage)
    {
        _damage = damage;
    }
}
