using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public SpriteAnimations spriteAnimations;
	public PlayerInfo player = new PlayerInfo();
	public List<Levels> levels = new List<Levels>();
	public GuiManager guiManager;
	// Use this for initialization
	void Start () {
		
	}
	public void MainButtonClicked()
	{
		spriteAnimations.CreateParticleAnimation();
		player.coins += player.clickValue;
		guiManager.creditsText.text=player.coins.ToString();
	}
	int LevelCheck(int points)
	{
		int level = 0;//levels[points].mincoins;//todo

		return level;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
public class PlayerInfo
{
public	int level = 0;
public	int coins = 0;
public	int clickValue = 1;

}
public class Levels
{
	int minCoins;
	int maxCoins;





}
