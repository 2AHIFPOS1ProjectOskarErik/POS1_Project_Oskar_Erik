using UnityEngine;
using UnityEngine.SceneManagement;
public class Startmenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayGame()
    {
        SceneManager.LoadScene("Checkpoint 1 Tutorial");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
