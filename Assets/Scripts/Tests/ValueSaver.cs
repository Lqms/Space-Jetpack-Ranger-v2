using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ValueSaver : MonoBehaviour
{
    [SerializeField] private InputField _inputField;

    public event UnityAction<float> MoneySaved;

    public void SaveValue()
    {
        Debug.Log(_inputField.text);
        MoneySaved?.Invoke(float.Parse(_inputField.text));
    }
}
