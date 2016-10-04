using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public GameObject LevelHolder;
	public const int X = 30;
	public const int Y = 30;
	public GameObject[,] Level = new GameObject[X,Y];

	 


	// Use this for initialization
	void Start () {

		var objects = LevelHolder.GetComponentsInChildren<Transform> ();

		foreach (var child in objects) 
		{
			Level [(int)child.position.x, (int)child.position.y] = child.gameObject;
		}
		Level [0, 0] = null;


	
	}
	

}
