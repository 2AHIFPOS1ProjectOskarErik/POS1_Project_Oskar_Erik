using UnityEngine;
using UnityEngine.InputSystem;

public class Map : MonoBehaviour
{
    public GameObject mapImage; // Das UI-Bild der Karte
    public static Map instance;
    private bool isOpen = false;

    void Start()
    {
        //ChatGPT code anfang Prompt: verschöner mir das und mach es übersichtlicher
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        mapImage.SetActive(false);
        DontDestroyOnLoad(gameObject);
        //ChatGPT code ende
    }

    void Update()
    {
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            isOpen = !isOpen;
            mapImage.SetActive(isOpen);
        }
    }
}