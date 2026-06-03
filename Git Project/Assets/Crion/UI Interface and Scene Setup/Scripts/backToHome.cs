using UnityEngine;
using UnityEngine.SceneManagement;
public class backToHome : MonoBehaviour
{
    public void returnToHome()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
