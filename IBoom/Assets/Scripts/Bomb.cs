using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	public GameObject Fire;
	public int FirePower;
	public float Fuse;
	GameController Gc;


	// Use this for initialization
	void Start () {
	
		Invoke ("Explode", Fuse);
		Gc = GameObject.Find("GameController").GetComponent<GameController>();

	}

	public void Explode() 
	{
		CancelInvoke ("Explode");

		Vector3[] directions = new Vector3[] {
			Vector3.up,
			Vector3.down,
			Vector3.left,
			Vector3.right

		};


		Instantiate (Fire, transform.position, Quaternion.identity);

		foreach (var direction in directions) 
		{
			SpawnFire (direction);
		}

		Destroy(gameObject);
	}

	private void SpawnFire(Vector3 offset, int Fire = 1)
	{
		 
		int x = (int)transform.position.x + (int)offset.x * Fire;
		int y = (int)transform.position.y + (int)offset.y * Fire;

		Mathf.Clamp (x, 0, GameController.X - 1);
		Mathf.Clamp (y, 0, GameController.Y - 1);

		if (Gc.Level[x, y] == null && Fire < FirePower) 
		{
			Instantiate (this.Fire, transform.position + (offset * Fire), Quaternion.identity);
			SpawnFire (offset, ++ Fire);
		} 
		else if (Fire < FirePower)
		{
			if (Gc.Level [x, y] != null && Gc.Level [x, y].tag == "Destroyable") 
			{
				Instantiate (this.Fire, transform.position + (offset * Fire), Quaternion.identity);
			}
		}
	}

	  
	public void OnTriggerExit2D(Collider2D collision)
	{
		GetComponent<BoxCollider2D> ().isTrigger = false;
	}



	// Update is called once per frame
	void Update () {
	
	}


}
