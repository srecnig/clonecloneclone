using UnityEngine;
using System.Collections;

public class CloneImplodeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision c){
		if (c.gameObject.name != "wall"){
			if (this.gameObject.tag == "neutral" && c.gameObject.tag == "Arrow")
			Destroy (c.collider.transform.root.gameObject);
			Destroy (this.gameObject);
		}
	}
}
