using UnityEngine;
using TMPro;

public class Geld_anzeige : MonoBehaviour
{
    // anfang ChatGPT code
    public static Geld_anzeige Instance;
    // ende ChatGPT code

    public TextMeshProUGUI moneyText;

    public int money;

    void Awake()
    {
        // anfang ChatGPT code
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        // ende ChatGPT code
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddMoney(int amount)
    {
        money += amount;

        UpdateUI();

    }

    public void UpdateUI()
    {
        moneyText.text = money.ToString();
    }
}