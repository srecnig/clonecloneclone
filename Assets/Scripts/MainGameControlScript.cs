using UnityEngine;
using System.Collections;

public class MainGameControlScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			// Reload the level.
			Debug.Log("Loading Scene");
			Application.LoadLevel("theGrid");
		}
	}
}
