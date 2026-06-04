using UnityEngine;
using UnityEngine.SceneManagement;
public class playButton : MonoBehaviour
{
    public void playMenue()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void exitButton()
    {
        Application.Quit();
    }
    
}
