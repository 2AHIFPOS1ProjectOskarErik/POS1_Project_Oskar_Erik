using UnityEngine;
using UnityEngine.InputSystem;

public class Map : MonoBehaviour
{
    public GameObject mapImage; // Das UI-Bild der Karte
    public static Map instance;
    private bool isOpen = false;

    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        mapImage.SetActive(false);
        DontDestroyOnLoad(gameObject);
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