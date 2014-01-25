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
		if (c.collider.name == "neutral" || c.collider.name == "clone") {
			on = true;
			// TODO: check if all the other switches for the same target are on
			GameObject door = GameObject.Find(isSwitchFor);
			// door.remove material
			// door.remove wall script
			Debug.Log("PRESSED SWITCH!");
		}
	}

	void OnCollisionExit(Collision c) {
		on = false;
		// door.add material
		// door.add wall script
		Debug.Log("LEFT SWITCH!");
	}
}
