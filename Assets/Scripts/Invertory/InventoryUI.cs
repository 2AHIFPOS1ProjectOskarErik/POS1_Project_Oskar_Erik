using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance;

    public GameObject inventoryPanel;

    bool isOpen = false;

    // INVENTAR LISTE
    public List<string> items = new List<string>();

    void Awake()
    {
        Instance = this;
    }

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

    // ITEM HINZUFÜGEN
    public void AddItem(string itemName)
    {
        items.Add(itemName);

        Debug.Log(itemName + " wurde ins Inventar gelegt!");
    }
}