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
        //text.rectTransform.anchoredPosition = new Vector2(-5f, 75f);

        if (timer >= 0.1f && text.text == "Druecke \"E\" um mit mir zu Interagieren!")
        {
            Debug.Log("John Dialog 1 ausgeführt");
            text.text = "Drücke \"Space\" um zu Springen!";
            timer = 0f;

        }
        if (timer >= 0.5f && text.text == "Drücke \"Space\" um zu Springen!")
        {
            text.text = "Drücke \"A\" um nach Links zu gehen \n und \"D\" um nach Rechts zu gehen!";
            Debug.Log("John Dialog 2 ausgeführt");
            timer = 0.5f;


        }
        if (timer >= 1f && text.text == "Drücke \"A\" um nach Links zu gehen \n und \"D\" um nach Rechts zu gehen!")
        {
            text.text = "Drücke \"S\" um dich zu Ducken!";
            Debug.Log("John Dialog 3 ausgeführt");
            timer = 1f;

        }
        if (timer >= 1.5f && text.text == "Drücke \"S\" um dich zu Ducken!")
        {
            text.text = "Drücke \"Linke Maustaste\" \n um Anzugreifen!";
            Debug.Log("John Dialog 4 ausgeführt");
            timer = 1.5f;

        }
        if (timer >= 2f && text.text == "Drücke \"Linke Maustaste\" \n um Anzugreifen!")
        {
            text.text = "Drücke R um dich zu Heilen!";
            Debug.Log("John Dialog 5 ausgeführt");
            timer = 2f;

        }
        if (timer >= 2.5f && text.text == "Drücke \"Linke Maustaste\" \n um Anzugreifen!")
        {
            text.text = "Drücke T um einen stärkenden Trank zu trinken!";
            Debug.Log("John Dialog 6 ausgeführt");
            timer = 2.5f;

        }
        if (timer >= 3f && text.text == "Drücke T um einen stärkenden Trank zu trinken!")
        {
            text.text = "Drücke R um dich zu Heilen!";
            Debug.Log("John Dialog 7 ausgeführt");
            timer = 3f;

        }

        if (timer >= 3.5f && text.text == "Drücke R um dich zu Heilen!")
        {
            Debug.Log("John Dialog beendet");
            text.text = "";
            return true;
        }
        return false;
    }
}

