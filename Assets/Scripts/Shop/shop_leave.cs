using UnityEngine;
using UnityEngine.SceneManagement;
public class shop_leave : MonoBehaviour
{
    public GameObject player;

    public void PlayGame()
    {
        SceneManager.LoadScene("Schloss");

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // chatgpt code anfang
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Schloss")
        {
            GameObject p = GameObject.FindGameObjectWithTag("Player");

            if (p != null)
            {
                p.transform.position = Vector2.zero;
            }

            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }
    // chatgpt code ende
}
