
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
            Debug.Log("Im Tutorial respawned");
            SceneManager.LoadScene("Tutorial");
            Debug.Log("Tutorial geladen");
        }
        if (playercode.current_Checkpoint == 1)
        {
            Debug.Log("Im Dungeon respawned");
            SceneManager.LoadScene("Dungeon");
            Debug.Log("Dungeon geladen");
        } 
        if (playercode.current_Checkpoint == 2)
        {
            Debug.Log("In der Crystal Cave respawned");
            SceneManager.LoadScene("Crystal Cave");
            Debug.Log("Crystal Cave geladen");
        }
        player.transform.position = playercode.Checkpoints[playercode.current_Checkpoint];
        playercode.HPAnzeige.UpdateHP();
    }
    public void MainMenu()
    {
        Debug.Log("Ins Hauptmenu zuruck gekehrt");
        SceneManager.LoadScene("Startmenu");
        Debug.Log("Startmenu geladen");
        

    }
}
