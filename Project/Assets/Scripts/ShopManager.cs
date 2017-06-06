using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections.Generic; // Import the System.Collections.Generic class to give us access to List<>


public class ShopManager : MonoBehaviour {
	[System.Serializable]
	public class Item
	{
		public string name;
		public int maxLevel;
		public int minCoins;
		public int level;
		public Sprite image;
		public int coinsStep;
		public string longName;
		public enum role{moreClickers, moreCoins, fasterClicks, wasteMoney}; 
		public role Tests;

	}
	public GameObject shopWindow;
	public List<Item> shopItem = new List<Item>(0);
	public List<ShopItem> items = new List<ShopItem>();
	// Use this for initialization
	public void BuyUpgrade(int index)
	{
		//shopItem[index];
	}

	public void Start()
	{
		
	}
	public void OpenShopWindow()
	{
		RefreshWindow();
		shopWindow.SetActive(true);
	}
	public void Madeit()
	{
		
	

	}
	public void RefreshWindow()
	{
		int i = 0;
		foreach(ShopItem item in items)
		{
			item.SetUpItem(i,shopItem[i].image,shopItem[i].longName,shopItem[i].minCoins+(shopItem[i].level*shopItem[i].coinsStep));
			i++;
		}
	}
	void AddNew(){
		//Add a new index position to the end of our list
		shopItem.Add(new Item());
	}

	void Remove(int index){
		//Remove an index position from our list at a point in our list array
		shopItem.RemoveAt(index);
	}
}
