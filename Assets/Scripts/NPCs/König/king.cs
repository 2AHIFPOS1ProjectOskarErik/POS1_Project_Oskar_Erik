using TMPro;
using UnityEngine;

public class king : MonoBehaviour
{
    public TextMeshProUGUI text;

    float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = "Trete heran!";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    public bool RunDialog()
    {

        if (text.text == "Trete heran!")
        {
            text.text = "Oh holder Ritter, tritt frohen Mutes hinab in die Tiefen des Kerkers!";
            timer = 0f;

        }
        if (timer >= 0.5f && text.text == "Oh holder Ritter, tritt frohen Mutes hinab in die Tiefen des Kerkers!")
        {
            text.text = "Den Eingang findest du beim Brunnen am Marktplatz";

            timer = 0.5f;
            return true;

        }
        
        return false;
    }
}
