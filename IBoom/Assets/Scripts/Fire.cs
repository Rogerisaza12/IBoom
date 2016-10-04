using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 0.5f);
	}

	void update()
	{
		
	}
	
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.GetComponent<Fire> () == null) 
		{
			Destroy (collision.gameObject);
		}

		if(collision.gameObject.GetComponent<Bomb>() !=null)
		{
			collision.gameObject.GetComponent<Bomb> ().Explode ();
		}



	}
}
