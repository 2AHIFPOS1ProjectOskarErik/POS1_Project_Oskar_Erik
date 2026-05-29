using UnityEngine;
using UnityEngine.SceneManagement;
public class shop_leave : MonoBehaviour
{
    public Movement player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayGame()
    {
        SceneManager.LoadScene("Schloss");
        transform.position = new Vector2(0, 0);
    }
}
