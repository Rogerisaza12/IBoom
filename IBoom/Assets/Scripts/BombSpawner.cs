using UnityEngine;
using System.Collections;

public class BombSpawner : MonoBehaviour {

	public GameObject Bomb; 
	public int numberOfBombs = 1;
	public int FirePower = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") && numberOfBombs >= 1) 
		{
			Vector2 spawnPos = new Vector2 (Mathf.Round (transform.position.x), Mathf.Round (transform.position.y));
			var newBomb = Instantiate (Bomb, transform.position, Quaternion.identity)as GameObject;
			newBomb.GetComponent<Bomb> ().FirePower = FirePower; 
			numberOfBombs--; 
			Invoke ("AddBomb", 1);
		}
	}

		public void AddBomb()
	{
		numberOfBombs++;
	}
}
