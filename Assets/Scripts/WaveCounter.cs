using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveCounter : MonoBehaviour
{
    [SerializeField] private int _waveCount = 0;

    public void Initialize(int value)
    {
        _waveCount = value;
    }

    public void AddWave(int value)
    {
        _waveCount += value;
        PlayerPrefs.SetInt("Wave", _waveCount);
    }
}
