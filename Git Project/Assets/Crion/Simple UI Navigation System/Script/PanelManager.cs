using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject homePanel;
    public GameObject settingsPanel;
    public GameObject aboutPanel;

    public void OpenHome()
    {
        mainMenuPanel.SetActive(false);
        homePanel.SetActive(true);
    }

    public void OpenSettings()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void OpenAbout()
    {
        mainMenuPanel.SetActive(false);
        aboutPanel.SetActive(true);
    }

    public void BackToMainMenu()
    {
        mainMenuPanel.SetActive(true);
        homePanel.SetActive(false);
        settingsPanel.SetActive(false);
        aboutPanel.SetActive(false);
    }

    public void BackToHome()
    {
        homePanel.SetActive(true);
        settingsPanel.SetActive(false);
        mainMenuPanel.SetActive(false );
        aboutPanel.SetActive(false);
    }
}