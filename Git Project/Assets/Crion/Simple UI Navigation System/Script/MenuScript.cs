using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject nextPanel;

    public void PanelDiverting()
    {
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
}
