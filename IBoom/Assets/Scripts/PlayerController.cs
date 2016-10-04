using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb2d;



	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();



	}

	// Update is called once per frame
	void Update () {

		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");

		if (Mathf.Abs(x) >= Mathf.Abs(y))
			y = 0;
		else if (Mathf.Abs(y) >= Mathf.Abs (x))
			x = 0;

		Vector2 movement = new Vector2 (x, y) * speed;
		rb2d.velocity = movement;


	} 
}
