using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IJunior.TypedScenes;

public class Menu : MonoBehaviour
{
    [SerializeField] private Settings _settingsPanel;

    [Header("UI Elements")]
    [SerializeField] private Button _start;
    [SerializeField] private Button _upgrades;
    [SerializeField] private Button _settings;
    [SerializeField] private Button _exit;


    private void OnEnable()
    {
        _settingsPanel.Closed += OnSettingsClosed;

        _start.onClick.AddListener(OnStartButtonClicked);
        _upgrades.onClick.AddListener(OnUpgradesButtonClicked);
        _settings.onClick.AddListener(OnSettingsButtonClicked);
        _exit.onClick.AddListener(OnExitButtonClicked);

        _start.interactable = false;
        _upgrades.interactable = false;
        _settings.interactable = false;
        _exit.interactable = false;
    }

    private void OnDisable()
    {
        _settingsPanel.Closed -= OnSettingsClosed;

        _start.onClick.RemoveListener(OnStartButtonClicked);
        _upgrades.onClick.RemoveListener(OnUpgradesButtonClicked);
        _settings.onClick.RemoveListener(OnSettingsButtonClicked);
        _exit.onClick.RemoveListener(OnExitButtonClicked);
    }

    private void OnAnimationFinished()
    {
        _start.interactable = true;
        _upgrades.interactable = true;
        _settings.interactable = true;
        _exit.interactable = true;
    }

    private void OnStartButtonClicked()
    {
        Game.Load();
    }

    private void OnUpgradesButtonClicked()
    {
        Upgrades.Load();
    }

    private void OnSettingsButtonClicked()
    {
        _settingsPanel.gameObject.SetActive(true);
    }

    private void OnSettingsClosed()
    {
        _settingsPanel.gameObject.SetActive(false);
    }

    private void OnExitButtonClicked()
    {
        Application.Quit();
    }
}
