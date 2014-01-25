using UnityEngine;
using System.Collections;

public class WallCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c){
		// arrows shall not pass through a wall
		if (c.gameObject.tag == "Arrow") {
			Destroy(c.collider.gameObject);
		}

		// clone shall not pass through a wall
		if (Input.GetKey(KeyCode.W)) {
			c.gameObject.transform.parent.Translate(0,-1,0);
		}
		if (Input.GetKey(KeyCode.S)) {
			c.gameObject.transform.parent.Translate(0,1,0);
		}
	}
}
