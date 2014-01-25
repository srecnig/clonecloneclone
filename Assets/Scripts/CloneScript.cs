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
			GameObject clones = Instantiate(Resources.Load("clone")) as GameObject;
			clones.transform.position = this.gameObject.transform.position;
			clones.transform.rotation = this.gameObject.transform.rotation;
			clones.transform.Rotate(0,0,90);
			Destroy(this.gameObject);
		}
	}
}
