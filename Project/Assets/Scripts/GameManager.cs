using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public SpriteAnimations spriteAnimations;
	public SoundManager soundManager;
	public ShopManager shopManager;
	public PlayerInfo player = new PlayerInfo();
	public List<Levels> levels = new List<Levels>();
	public GuiManager guiManager;

	void Start () {

		//ony for test
	//	StartCoroutine(SearchForTargetRepeat());
	
		//InvokeRepeating(;

		//only for test
	}



	IEnumerator SearchForTargetRepeat() {
		while(true) {
			MainButtonClicked(new Vector3(Random.Range(0,Screen.width),Random.Range(0,Screen.height),390));
			yield return new WaitForSeconds(player.time);
		}
	}
	public void ItemBuy(int id)
	{
		player.coins = player.coins - shopManager.shopItem[id].minCoins;
		shopManager.shopItem[id].level++;
		shopManager.RefreshWindow();
		player.coins = player.clickValue;
		switch(id)
		{
		case 0:
			StartCoroutine(SearchForTargetRepeat());
			break;
		case 1: 
			player.clickValue++;
			break;
		case 2:
			player.time = player.time -0.05f;
			break;
		case 3: break;
		}

	}
	public void MainButtonClicked(Vector3 point)
	{
		spriteAnimations.CreateParticleAnimation(point,soundManager.splashSounds[Random.Range(0,soundManager.splashSounds.Length)]);
		player.coins += player.clickValue;

		//player.coins.ToString();

	}
	int LevelCheck(int points)
	{
		int level = 0;//levels[points].mincoins;//todo

		return level;
	}
	float test =0;
	// Update is called once per frame
	void Update() {
		
		test = Mathf.Lerp(test,player.coins,Time.deltaTime*5);
		guiManager.creditsText.text = test.ToString("F0");
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			if (hit.collider != null){
				Debug.Log(hit.point);
				//hit.rigidbody.AddForceAtPosition(ray.direction * pokeForce, hit.point);
				MainButtonClicked(hit.point);
			}

		}
	}
}
public class PlayerInfo
{
public	int level = 0;
public	int coins = 0;
public	int clickValue = 1;
	public float time = 1.0f;

}
public class Levels
{
	int minCoins;
	int maxCoins;





}
