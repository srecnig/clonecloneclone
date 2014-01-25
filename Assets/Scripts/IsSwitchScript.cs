using UnityEngine;
using System.Collections;

public class IsSwitchScript : MonoBehaviour {

	public string isSwitchFor;
	public bool on;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c) {
		if (!c.gameObject.name.Equals("wall")) {
			// check if it's the player
			Debug.Log("PRESSED SWITCH!");
			on = true;
			// TODO: check if all the other switches for the same target are on
			GameObject door = GameObject.Find(isSwitchFor);
			// door.remove material renderer
			door.GetComponent<WallCollider>().enabled = false;
			door.GetComponent<BoxCollider>().enabled = false;
		}
	}

	void OnCollisionExit(Collision c) {
		on = false;
		// door.add material
		GameObject door = GameObject.Find(isSwitchFor);
		door.GetComponent<WallCollider>().enabled = true;
		door.GetComponent<BoxCollider>().enabled = true;
		Debug.Log("LEFT SWITCH!");
	}
}
