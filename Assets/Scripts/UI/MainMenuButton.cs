using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using IJunior.TypedScenes;

[RequireComponent(typeof(Button))]
public class MainMenuButton : MonoBehaviour
{
    private Button _exitToMainMenu;

    private void OnEnable()
    {
        _exitToMainMenu = GetComponent<Button>();
        _exitToMainMenu.onClick.AddListener(SwitchToMainMenu);
    }

    private void OnDisable()
    {
        _exitToMainMenu.onClick.RemoveListener(SwitchToMainMenu);   
    }

    private void SwitchToMainMenu()
    {
        MainMenu.Load();
    }
}
