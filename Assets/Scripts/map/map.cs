using UnityEngine;
using UnityEngine.InputSystem;

public class Map : MonoBehaviour
{
    public GameObject mapImage; // Das UI-Bild der Karte

    private bool isOpen = false;

    void Start()
    {
        mapImage.SetActive(false);
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