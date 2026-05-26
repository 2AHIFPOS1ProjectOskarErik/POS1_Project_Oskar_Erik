using Microsoft.Unity.VisualStudio.Editor;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
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
    }
    void Start()
    {
        DontDestroyOnLoad(HerzPrefab);
        for (int i = 0; i < maxHP; i++)
        {
            GameObject Herz = Instantiate(HerzPrefab, Herzparent);
            Herz.transform.position = new Vector2(HerzPrefab.transform.position.x + (i * 55f), HerzPrefab.transform.position.y);
            Herz.GetComponent<UnityEngine.UI.Image>().enabled = true;
            Herzen.Add(Herz.GetComponent<UnityEngine.UI.Image>());
        }
    }

    // Update is called once per frame
    public void UpdateHP()
    {
        currentHP -= 1;
        for (int i = 0; i < Herzen.Count; i++) 
        {
            
            if (i < currentHP)
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
