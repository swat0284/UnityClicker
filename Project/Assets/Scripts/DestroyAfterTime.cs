using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {
	public float time= 3;
	// Use this for initialization
	void OnEnable () {
		
		Invoke("DestroyObject",time);
	}
	void DestroyObject()
	{
		Destroy(this.gameObject);	
	}

}
