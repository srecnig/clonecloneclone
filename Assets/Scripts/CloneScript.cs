using UnityEngine;
using System.Collections;

public class CloneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		string tag = collision.gameObject.tag;
		if (this.gameObject.tag == "Neutral" && tag == "Arrow") {
			// Debug.Log("COLLISION with: " +  collision.gameObject.tag);
			if (this.gameObject.GetComponent("movement") == null) {
				this.gameObject.AddComponent("movement");
			}
			if (this.gameObject.GetComponent("ShootScript") == null) {
				this.gameObject.AddComponent("ShootScript");
			}
			this.gameObject.tag = "Player";
		}
		
	}
}
