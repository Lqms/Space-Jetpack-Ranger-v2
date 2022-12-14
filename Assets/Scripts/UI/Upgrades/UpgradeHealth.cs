using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeHealth : Upgrade
{
    [SerializeField] private float _extraHealth;

    protected override void OnEnable()
    {
        base.OnEnable();

        CostMultiplier = PlayerPrefs.GetFloat(StringConsts.Health.ToString());
        CostText.text = (BaseCost * CostMultiplier / Divider).ToString() + "K";
    }

    protected override void Buy()
    {
        PlayerPrefs.SetFloat(StringConsts.Health.ToString(), PlayerPrefs.GetFloat(StringConsts.Health.ToString()) + _extraHealth);
        CostMultiplier = PlayerPrefs.GetFloat(StringConsts.Health.ToString());
        CostText.text = (BaseCost * CostMultiplier / Divider).ToString() + "K";
    }
}
