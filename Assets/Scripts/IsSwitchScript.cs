using UnityEngine;
using System.Collections;

public class IsSwitchScript : MonoBehaviour {

	public string isSwitchFor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c) {
		// only if the player or a clone pressed it.
		Debug.Log("PRESSED SWITCH!");
	}

	void OnCollisionExit(Collision c) {
		GameObject door = GameObject.Find(isSwitchFor);
		Debug.Log("LEFT SWITCH! destroying: " + door);
		Destroy(door);
	}
}
