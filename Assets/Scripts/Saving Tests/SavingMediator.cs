using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingMediator : MonoBehaviour
{
    [SerializeField] private PlayerWallet _wallet;
    [SerializeField] private Player _player;
    [SerializeField] private WaveCounter _waveCounter;

    private const string Money = nameof(Money);
    private const string Damage = nameof(Damage);
    private const string Wave = nameof(Wave);

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
        /*
        if (PlayerPrefs.HasKey(Money))
            _wallet.Initialize(PlayerPrefs.GetFloat(Money));
        else
            _wallet.Initialize(10_000);

        if (_player != null)
        {
            if (PlayerPrefs.HasKey(Damage))
                _player.Initialize(PlayerPrefs.GetFloat(Damage));
            else
                _player.Initialize(50);
        }

        if (_waveCounter != null)
        {
            if (PlayerPrefs.HasKey(Wave))
                _waveCounter.Initialize(PlayerPrefs.GetInt(Wave));
            else
                _waveCounter.Initialize(0);
        }
        */
    }

    private void OnMoneyChanged(float newValue)
    {
        PlayerPrefs.SetFloat(Money, newValue);
    }
}
