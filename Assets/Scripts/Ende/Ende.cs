using UnityEngine;
using UnityEngine.SceneManagement;
public class Ende: MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Gewonnen, zurück zum main menu");
        SceneManager.LoadScene("Startmenu");
    }
}
