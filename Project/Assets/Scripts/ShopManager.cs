using UnityEngine;
using System;
using System.Collections.Generic; // Import the System.Collections.Generic class to give us access to List<>


public class ShopManager : MonoBehaviour {
	[System.Serializable]
	public class Item
	{
		public string name;
		public int maxLevel;
		public int minCoins;
		public enum function {moreClickers, moreCoins}; 

	}
	public List<Item> shopItem = new List<Item>(0);
	// Use this for initialization

	void Start()
	{
		AddNew();
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
