using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StringConsts
{
    Health,
    Damage,
    Energy,
    Money,
    Wave
}

public class SavingMediator : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerWallet _wallet;

    [SerializeField] private UpgradeDamage _upgradeDamage; // 6 полей будет для ссылок на апргейд и вью
    [SerializeField] private UpgradeView _upgradeDamageView; // для других апргрейдов также


    private const string Money = nameof(Money);
    private const string Damage = nameof(Damage);

    private void OnEnable()
    {
        _wallet.MoneyChanged += OnMoneyChanged;
        _upgradeDamage.DamageIncreased += OnDamageIncreased;
    }

    private void OnDisable()
    {
        _wallet.MoneyChanged -= OnMoneyChanged;
        _upgradeDamage.DamageIncreased -= OnDamageIncreased;
    }

    private void Start()
    {
        _player.Initialize(PlayerPrefs.GetFloat(Damage));
        _wallet.Initialize(PlayerPrefs.GetFloat(Money));

        _upgradeDamage.Initialize(PlayerPrefs.GetFloat(Damage));
        _upgradeDamageView.Initialize(PlayerPrefs.GetFloat(Damage));
    }

    private void OnMoneyChanged(float value)
    {
        PlayerPrefs.SetFloat(Money, value);
    }

    private void OnDamageIncreased(float value)
    {
        PlayerPrefs.SetFloat(Damage, value);
    }
}
