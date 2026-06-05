using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance;

    public GameObject inventoryPanel;

    public TMP_Text healthText;
    public TMP_Text strengthText;
    public TMP_Text coinText;

    bool isOpen = false;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        inventoryPanel.SetActive(false);
        UpdateTexts();
    }

    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            isOpen = !isOpen;
            inventoryPanel.SetActive(isOpen);
        }
    }

    public void UpdateTexts()
    {
        healthText.text = PlayerPrefs.GetInt("Health", 0).ToString();
        strengthText.text = PlayerPrefs.GetInt("Strength", 0).ToString();

    }
}