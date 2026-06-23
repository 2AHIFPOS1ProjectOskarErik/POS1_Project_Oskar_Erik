using UnityEngine;
using TMPro;

public class Geld_anzeige : MonoBehaviour
{
    public static Geld_anzeige Instance;

    public TextMeshProUGUI moneyText;
    public int money;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            // Gespeichertes Geld laden
            money = PlayerPrefs.GetInt("coin", 2000);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddMoney(int amount)
    {
        money += amount;

        PlayerPrefs.SetInt("coin", money);
        
        UpdateUI();
    }

    public void RemoveMoney(int amount)
    {
        money -= amount;

        PlayerPrefs.SetInt("coin", money);

        UpdateUI();
    }

    public void UpdateUI()
    {
        moneyText.text = money.ToString();
    }
}