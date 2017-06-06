using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour {
	public GameManager gameManager;
	public GuiManager guiManager;
	public Image itemImage;
	public Text itemText;
	public Text itemButtonText;
	public int itemIndex;
	public int itemPrice;
	public bool isAlreadySet = false;
	public void SetUpItem(int index, Sprite image, string text, int price)
	{
		itemImage.sprite = image;
		itemText.text = text;
		itemIndex = index;
		itemButtonText.text = price.ToString();
		itemPrice = price;
	}
	public void TryToBuy()
	{
		if(gameManager.player.coins >= itemPrice)
		{

			gameManager.ItemBuy(itemIndex);

		}
		else
		{
			Debug.Log("test");
			guiManager.ShowAlert(0);//id 0 dont have money

		}

	}
}
