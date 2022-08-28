using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Upgrade : MonoBehaviour
{
    [SerializeField] private PlayerWallet _wallet;

    [SerializeField] protected Text CostText;
    [SerializeField] protected float BaseCost;

    protected float CostMultiplier = 1;

    private Button _button;

    protected const int Divider = 1000;

    protected virtual void OnEnable()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(OnUpgradeButtonClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnUpgradeButtonClicked);   
    }

    private void OnUpgradeButtonClicked()
    {
        if (_wallet.TrySpendMoney(BaseCost * CostMultiplier))
            Buy();
    }

    protected virtual void Buy()
    {

    }
}
