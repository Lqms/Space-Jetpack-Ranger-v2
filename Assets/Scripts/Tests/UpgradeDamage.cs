using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UpgradeDamage : MonoBehaviour
{
    [SerializeField] private PlayerWallet _wallet;
    [SerializeField] private float _cost;
    [SerializeField] private float _extraDamage;

    private Button _button;

    private const string Damage = nameof(Damage);

    private void OnEnable()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnUpgradeButtonClicked);

        if (PlayerPrefs.HasKey(Damage) == false)
            PlayerPrefs.SetFloat(Damage, 50);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnUpgradeButtonClicked);
    }

    private void OnUpgradeButtonClicked()
    {
        if (_wallet.TrySpendMoney(_cost))
        {
            PlayerPrefs.SetFloat(Damage, PlayerPrefs.GetFloat(Damage) + _extraDamage);
            Debug.Log(PlayerPrefs.GetFloat(Damage));
        }
    }
}
