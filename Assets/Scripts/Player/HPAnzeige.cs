using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HPAnzeige : MonoBehaviour
{

    public Transform Herzparent;
    public GameObject HerzPrefab;
    public Sprite HerzFull;
    public Sprite HerzEmpty;
    private List<UnityEngine.UI.Image> Herzen = new List<UnityEngine.UI.Image>();
    public double maxHP = 5;
    public static HPAnzeige instance;
    public double currentHP = 5;
    private GameObject player;
    private Movement playercode;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GameObject.Find("Player");
        playercode = player.GetComponent<Movement>();
    }

    void Start()
    {
        DontDestroyOnLoad(HerzPrefab);


        for (int i = 0; i < playercode.maxHP; i++)
        {
            GameObject Herz = Instantiate(HerzPrefab, Herzparent);
            Herz.transform.position = new Vector2(HerzPrefab.transform.position.x + (i * 55f), HerzPrefab.transform.position.y);
            Herz.GetComponent<UnityEngine.UI.Image>().enabled = true;
            Herzen.Add(Herz.GetComponent<UnityEngine.UI.Image>());
            UpdateHP();
        }
    }

    // Update is called once per frame
    public void UpdateHP()
    {
        for (int i = 0; i < Herzen.Count; i++) 
        {
            
            if (i < playercode.hp)
            {
                Herzen[i].sprite = HerzFull;
            }
            else
            {
                Herzen[i].sprite = HerzEmpty;
            }
        }
    }
    
    //ChatGPT code anfang
    public void AddHeart()
    {
        GameObject Herz = Instantiate(HerzPrefab, Herzparent);

        Herz.transform.position = new Vector2(
            HerzPrefab.transform.position.x + (Herzen.Count * 55f),
            HerzPrefab.transform.position.y
        );

        Herz.GetComponent<UnityEngine.UI.Image>().enabled = true;

        Herzen.Add(Herz.GetComponent<UnityEngine.UI.Image>());
    }
    //ChatGPT code ende

}
