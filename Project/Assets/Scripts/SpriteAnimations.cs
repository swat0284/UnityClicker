using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimations : MonoBehaviour {
	public List<Sprite> sprites = new List<Sprite>();
	public GameObject tempSpriteObject;
	// Use this for initialization
	void Start () {

	}
	public void CreateParticleAnimation(Vector3 position,AudioClip sound)
	{
		GameObject tempGameObject = Instantiate(tempSpriteObject);
		tempGameObject.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0,sprites.Count)];
		tempGameObject.SetActive(true);
		tempGameObject.GetComponent<AudioSource>().clip = sound;
		tempGameObject.transform.position = new Vector3(position.x,position.y,position.z);//12.50f,0);
		tempGameObject.GetComponent<AudioSource>().Play();
		tempGameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-360.0f,360.0f)*50,Random.Range(-360.0f,360.0f)*50));


	}
	// Update is called once per frame

		
	}

