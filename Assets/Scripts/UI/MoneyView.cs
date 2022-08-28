using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyView : MonoBehaviour
{
    [SerializeField] private PlayerWallet _wallet;
    [SerializeField] private Text _money;

    private const int Divider = 1000;

    private void OnEnable()
    {
        _wallet.MoneyChanged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _wallet.MoneyChanged -= OnMoneyChanged;
    }

    private void OnMoneyChanged(float value)
    {
        _money.text = (value / Divider).ToString() + "K";
    }
}
