using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dialog1 : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        text.text = "Hallo!";
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    public bool RunDialog()
    {
        text.transform.position = new Vector2(465f, 345f);
        if (timer >= 0.1f && text.text == "Drücke \"E\" um mit mir zu Interagieren!")
        {
            text.text = "Drücke \"Space\" um zu Springen!";
            timer = 0f;

        }
        if (timer >= 0.5f && text.text == "Drücke \"Space\" um zu Springen!")
        {
            text.text = "Drücke \"A\" um nach Links zu gehen und \"D\" um nach Rechts zu gehen!";
            
            timer = 0.5f;
            
            
        }
        if (timer >= 1f && text.text == "Drücke \"A\" um nach Links zu gehen und \"D\" um nach Rechts zu gehen!")
        {
            text.text = "Drücke \"S\" um dich zu Ducken!";
            
            timer = 1f;
            
        }
        if (timer >= 1.5f && text.text == "Drücke \"S\" um dich zu Ducken!")
        {
            text.text = "Drücke \"Linke Maustaste\" um Anzugreifen!";
            
            timer = 1.5f;
            
        }
       if (timer >= 2f && text.text == "Drücke \"Linke Maustaste\" um Anzugreifen!")
       {
            text.text = "";
            return true;
       }
        return false;
    }
}

