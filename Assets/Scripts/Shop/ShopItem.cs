using TMPro;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public int health;
    public int strength;

    public TMP_Text Coin_Text;

    void Start()
    {

        //chatGBT code anfang
        PlayerPrefs.SetInt("HealthUpBought", 0);
        health = PlayerPrefs.GetInt("Health", 0);
        strength = PlayerPrefs.GetInt("Strength", 0);
        //chatGBT code ende
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
    //ChatGPT code anfang
    public void Buy_HealthUp()
    {
        if (PlayerPrefs.GetInt("HealthUpBought", 0) == 1)
            return;

        if (Geld_anzeige.Instance.money < 100)
            return;

        Geld_anzeige.Instance.RemoveMoney(100);
        UpdateCoinText();
        PlayerPrefs.SetInt("HealthUpBought", 1);

        int maxHP = PlayerPrefs.GetInt("MaxHP", 5);
        PlayerPrefs.SetInt("MaxHP", maxHP + 1);

        PlayerPrefs.Save();


        Movement.instance.maxHP += 1;
        Movement.instance.hp += 1;

        HPAnzeige.instance.AddHeart();
        HPAnzeige.instance.UpdateHP();


        Debug.Log("HealthUp gekauft!");
    }
    //ChatGPT code ende
}