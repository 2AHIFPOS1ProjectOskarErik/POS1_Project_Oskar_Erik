using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public string itemName;
    public int price;

    public void BuyItem()
    {
        if (Geld_anzeige.Instance.money >= price)
        {
            Geld_anzeige.Instance.money -= price;

            Geld_anzeige.Instance.UpdateUI();

            InventoryUI.Instance.AddItem(itemName);

            Debug.Log(itemName + " gekauft!");
        }
        else
        {
            Debug.Log("Nicht genug Geld!");
        }
    }
}