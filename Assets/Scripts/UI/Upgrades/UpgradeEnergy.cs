using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeEnergy : UpgradeView
{
    /*
    [SerializeField] private float _extraEnergy;

    protected override void OnEnable()
    {
        base.OnEnable();

        CostMultiplier = PlayerPrefs.GetFloat(StringConsts.Energy.ToString());
        _cost.text = (_baseCost * CostMultiplier / Divider).ToString() + "K";
    }

    protected override void Buy()
    {
        PlayerPrefs.SetFloat(StringConsts.Energy.ToString(), PlayerPrefs.GetFloat(StringConsts.Energy.ToString()) + _extraEnergy);
        CostMultiplier = PlayerPrefs.GetFloat(StringConsts.Energy.ToString());
        _cost.text = (_baseCost * CostMultiplier / Divider).ToString() + "K";
    }
    */
}
