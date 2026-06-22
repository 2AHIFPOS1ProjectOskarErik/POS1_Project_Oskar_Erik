using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BossHP : MonoBehaviour
{
    public Transform Herzparent;
    public GameObject HerzPrefab;
    public Sprite HerzFull;
    public Sprite HerzEmpty;
    private List<UnityEngine.UI.Image> Herzen = new List<UnityEngine.UI.Image>();
    public double maxHP = 5;
    public static BossHP instance;
    public Boss boss;
    public double currentHP = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        
    }
    void Start()
    {
        DontDestroyOnLoad(HerzPrefab);
        for (int i = 0; i < boss.maxHP; i++)
        {
            GameObject Herz = Instantiate(HerzPrefab, Herzparent);
            Herz.transform.position = new Vector2(HerzPrefab.transform.position.x + (i * 5f), HerzPrefab.transform.position.y);
            Herz.GetComponent<UnityEngine.UI.Image>().enabled = true;
            Herzen.Add(Herz.GetComponent<UnityEngine.UI.Image>());
        }
    }

    public void UpdateHP()
    {

        for (int i = 0; i < Herzen.Count; i++)
        {

            if (i < boss.hp)
            {
                Herzen[i].sprite = HerzFull;
            }
            else
            {
                Herzen[i].sprite = HerzEmpty;
            }
        }
    }
}
