using UnityEngine;
using UnityEngine.SceneManagement;


public class Deathmenu : MonoBehaviour
{

    private GameObject player;
    private Movement playercode;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GameObject.Find("Player");
        playercode = player.GetComponent<Movement>();
    }

    public void Repawn()
    {
        if (playercode.current_Checkpoint == 0)
        {
            SceneManager.LoadScene("Tutorial");
        }
        if (playercode.current_Checkpoint == 1)
        {
            SceneManager.LoadScene("Dungeon");
        } 
        if (playercode.current_Checkpoint == 2)
        {
            SceneManager.LoadScene("Crystal Cave");
        }
        player.transform.position = playercode.Checkpoints[playercode.current_Checkpoint];
        playercode.HPAnzeige.UpdateHP();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Startmenu");
    }
}
