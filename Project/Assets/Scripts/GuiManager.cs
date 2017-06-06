using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiManager : MonoBehaviour {

	public Text creditsText;

	public GameObject alertWindow;
	public Text alertText;
	public List<string> alerts = new List<string>();
	public void ShowAlert(int id)
	{
		alertWindow.SetActive(true);
		//if(alerts.Count+1 = id)
			alertText.text = alerts[id];
		//else
		//	alertText.text = "ERROR 001";
	}



}
