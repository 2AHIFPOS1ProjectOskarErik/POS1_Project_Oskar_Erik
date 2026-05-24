using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryUI : MonoBehaviour
{
    //prompt: wie macht man ein Inventar in Unity
    //anfang ChatPT code
    public GameObject inventoryPanel;

    bool isOpen = false;

    void Start()
    {
        inventoryPanel.SetActive(false);
    }

    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            isOpen = !isOpen;

            inventoryPanel.SetActive(isOpen);
        }
    }
    //ende ChatPT code
}