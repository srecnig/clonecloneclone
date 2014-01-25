using UnityEngine;
using System.Collections;

public class InitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (GameObject.Find ("MainGameController(Clone)") == null) {
			Instantiate(Resources.Load("MainGameController")); 
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
