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
		if (tag == "Arrow") {
			Debug.Log("COLLISION with: " +  collision.gameObject.tag);
			if (this.gameObject.GetComponent("movement") == null) {
				this.gameObject.AddComponent("movement");
			}
		}
		
	}
}
