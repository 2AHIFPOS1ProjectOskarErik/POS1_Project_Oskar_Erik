using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance;

    public GameObject inventoryPanel;

    public TMP_Text healthText;
    public TMP_Text strengthText;
    public TMP_Text coinText;

    private bool isOpen = false;

    void Awake()
    {
        // Singleton-Schutz
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        // Objekt zwischen Szenen behalten
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if (inventoryPanel != null)
            inventoryPanel.SetActive(false);

        UpdateTexts();
    }

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.tabKey.wasPressedThisFrame)
        {
            isOpen = !isOpen;

            if (inventoryPanel != null)
                inventoryPanel.SetActive(isOpen);
        }
    }

    public void UpdateTexts()
    {
        if (healthText != null)
            healthText.text = PlayerPrefs.GetInt("Health", 0).ToString();

        if (strengthText != null)
            strengthText.text = PlayerPrefs.GetInt("Strength", 0).ToString();

        if (coinText != null)
            coinText.text = PlayerPrefs.GetInt("Coins", 0).ToString();
    }
}