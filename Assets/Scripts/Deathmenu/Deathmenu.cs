using UnityEngine;
using UnityEngine.SceneManagement;
public class Deathmenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public void Repawn()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Startmenu");
    }
}
