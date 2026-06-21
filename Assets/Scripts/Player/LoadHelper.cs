using System.IO;
using UnityEngine;

public class LoadHelper : MonoBehaviour
{
    public SaveHelper data;
    public bool wasLoaded = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        try
        {
            string json;
            using (StreamReader sr = new StreamReader("save.txt"))
            {
                json = sr.ReadLine();
            }
            data = JsonUtility.FromJson<SaveHelper>(json);
        }
        catch { }
        wasLoaded = true;
    }
}
 