using UnityEngine;
using System.Collections;

public class PUSpeed : MonoBehaviour {

	GameController Gc;


	// Use this for initialization
	void Start () 
	{
		Gc = GameObject.Find ("GameController").GetComponent<GameController> ();
		Gc.Level [(int)transform.position.x, (int)transform.position.y] = gameObject;
	}
	
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player") 
		{
			collision.gameObject.GetComponent<PlayerController> ().speed++;
			Destroy (gameObject);
		}
	}
}
