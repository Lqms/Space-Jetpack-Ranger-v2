using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeDamage : Upgrade
{
    [SerializeField] private float _extraDamage;

    protected override void OnEnable()
    {
        base.OnEnable();

        CostMultiplier = PlayerPrefs.GetFloat(StringConsts.Damage.ToString());
        CostText.text = (BaseCost * CostMultiplier / Divider).ToString() + "K";
    }

    protected override void Buy()
    {
        PlayerPrefs.SetFloat(StringConsts.Damage.ToString(), PlayerPrefs.GetFloat(StringConsts.Damage.ToString()) + _extraDamage);
        CostMultiplier = PlayerPrefs.GetFloat(StringConsts.Damage.ToString());
        CostText.text = (BaseCost * CostMultiplier / Divider).ToString() + "K";
    }
}
