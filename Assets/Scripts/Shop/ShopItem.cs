using TMPro;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public int health;
    public int strength;

    public TMP_Text Coin_Text;

    void Start()
    {
        health = PlayerPrefs.GetInt("Health", 0);
        strength = PlayerPrefs.GetInt("Strength", 0);

        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        Coin_Text.text = Geld_anzeige.Instance.money.ToString();
    }

public void Buy_strength()
{
    if (Geld_anzeige.Instance.money >= 40)
    {
        Geld_anzeige.Instance.RemoveMoney(40);

        strength++;

        PlayerPrefs.SetInt("Strength", strength);
        PlayerPrefs.Save();

        UpdateCoinText();

        InventoryUI.Instance.UpdateTexts();

        Debug.Log($"Strength purchased. Now you have {strength} strength potions.");
    }
}

public void Buy_Health()
{
    if (Geld_anzeige.Instance.money >= 20)
    {
        Geld_anzeige.Instance.RemoveMoney(20);

        health++;

        PlayerPrefs.SetInt("Health", health);
        PlayerPrefs.Save();

        UpdateCoinText();

        InventoryUI.Instance.UpdateTexts();

        Debug.Log($"Health purchased. Now you have {health} health potions.");
    }
}
}