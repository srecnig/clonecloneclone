using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {

	private GameObject mainController;

	// Use this for initialization
	void Start () {
		this.mainController = GameObject.Find("MainGameController(Clone)");
	}
	
	// Update is called once per frame
	void Update () {
	//	GameObject.FindGameObjectsWithTag("Player")
	}

	void OnCollisionEnter(Collision c) {
		// are you the player or a clone?
		// if yes, move to next level.
		if (c.gameObject.tag == "Player" || c.gameObject.tag == "clone") {
			MainGameControlScript mgs = (MainGameControlScript) this.mainController.GetComponent("MainGameControlScript");
			mgs.loadNextLevel();
			Debug.Log("MOVE ON TO THE FRACKIN NEXT LEVEL!");
		}

	}
}
