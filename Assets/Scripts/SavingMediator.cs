using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingMediator : MonoBehaviour
{
    [SerializeField] private PlayerWallet _wallet;

    private const string Money = nameof(Money);

    private void OnEnable()
    {
        _wallet.MoneyChanged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _wallet.MoneyChanged -= OnMoneyChanged;
    }

    private void Awake()
    {
        if (PlayerPrefs.HasKey(Money))
            _wallet.Initialize(PlayerPrefs.GetFloat(Money));
        else
            _wallet.Initialize(10_000);
    }

    private void OnMoneyChanged(float newValue)
    {
        PlayerPrefs.SetFloat(Money, newValue);
    }
}
