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
		if (Input.GetKey(KeyCode.W)) {
			c.gameObject.transform.parent.Translate(0,-1,0);
		}
		if (Input.GetKey(KeyCode.S)) {
			c.gameObject.transform.parent.Translate(0,1,0);
		}
	}
}
