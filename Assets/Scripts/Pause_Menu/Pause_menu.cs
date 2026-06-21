using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject container;
    public Movement player;
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            container.SetActive(true);
            Time.timeScale = 0;
        }

    }
    public void Resume()
    {
        container.SetActive(false);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        SceneManager.LoadScene("Startmenu");
    }

    public void Save()
    {
        player.Speichern();
    }
}
