using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private float _money;
    [SerializeField] private AudioClip _notEnoughtMoney;
    [SerializeField] private AudioClip _successfulBuy;

    public float Money => _money;

    public event UnityAction<float> MoneyChanged;

    private void OnEnable()
    {
        _money = PlayerPrefs.GetFloat(StringConsts.Money.ToString());
    }

    public void AddMoney(float value)
    {
        _money += value;
        MoneyChanged?.Invoke(_money);
    }

    public bool TrySpendMoney(float value)
    {
        if (_money >= value)
        {
            _money -= value;
            PlayerPrefs.SetFloat(StringConsts.Money.ToString(), _money);
            MoneyChanged?.Invoke(_money);
            AudioManager.Instance.PlayClip(_successfulBuy);
        }
        else
        {
            AudioManager.Instance.PlayClip(_notEnoughtMoney);
        }

        return _money >= value;
    }
}
