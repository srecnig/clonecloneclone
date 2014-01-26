using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//	GameObject.FindGameObjectsWithTag("Player")
	}

	void OnCollisionEnter(Collision c) {
		// are you the player or a clone?
		// if yes, move to next level.
		Debug.Log("MOVE ON TO THE FRACKIN NEXT LEVEL!");
	}
}
