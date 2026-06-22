using UnityEngine;
using UnityEngine.SceneManagement;
public class Startmenu : MonoBehaviour
{
    
    public GameObject Loadhelp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Awake()
    {
        Debug.Log("Test");
    }
    public void PlayGame()
    {
        Debug.Log("Neuen Spielstand gestartet");
        SceneManager.LoadScene("Tutorial");
    }
    public void QuitGame()
    {
        Debug.Log("Spiel geschlossen");
        Application.Quit();
        
    }

    public void ContinueGame()
    {
        Debug.Log("Alten Spielstand geladen");
        Loadhelp.GetComponent<LoadHelper>().Load();
    }
}
