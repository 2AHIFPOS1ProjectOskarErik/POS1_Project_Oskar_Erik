using UnityEngine;
using UnityEngine.SceneManagement;
public class Startmenu : MonoBehaviour
{
    public GameObject Loadhelp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ContinueGame()
    {

    }
}
