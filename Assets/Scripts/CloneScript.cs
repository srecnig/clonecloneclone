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
			if (this.transform.parent.gameObject.GetComponent("movement") == null) {
				this.transform.parent.gameObject.AddComponent("movement");
			}
			if (this.transform.parent.gameObject.GetComponent("ShootScript") == null) {
				this.transform.parent.gameObject.AddComponent("ShootScript");
			}
			this.gameObject.tag = "Player";
		}
		
	}
}
