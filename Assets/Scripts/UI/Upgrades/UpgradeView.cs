using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UpgradeView : MonoBehaviour
{
    [SerializeField] private PlayerWallet _wallet;
    [SerializeField] private Text _cost;
    [SerializeField] private IUpgrade _upgrade;
    [SerializeField] private float _baseCost;

    private float _currentCost;
    private Button _button;

    private const int Divider = 1000;

    private void OnEnable()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    public void Initialize(float costMultiplier)
    {
        _currentCost = _baseCost * costMultiplier;
        _cost.text = (_currentCost / Divider).ToString() + "K";
    }

    private void OnButtonClicked()
    {
        if (_wallet.TrySpendMoney(_currentCost))
        {
            _upgrade.Apply();
        }
    }
}
