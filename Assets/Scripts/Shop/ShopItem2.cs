using UnityEngine;
using TMPro;
public class ShopItem2
{
    public int speed;
    public TMP_Text Coin_Text;
    void Start()
    {

        //chatGBT code anfang
        speed = PlayerPrefs.GetInt("Speed", 0);
        //chatGBT code ende
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        Coin_Text.text = Geld_anzeige.Instance.money.ToString();
    }
    public void Buy_Speed()
    {
        if (Geld_anzeige.Instance.money >= 30)
        {
            Geld_anzeige.Instance.RemoveMoney(30);

            speed++;

            PlayerPrefs.SetInt("Speed", speed);
            PlayerPrefs.Save();

            UpdateCoinText();

            InventoryUI.Instance.UpdateTexts();

            Debug.Log($"Speed purchased. Now you have {speed} speed upgrades.");
        }
    }
}
