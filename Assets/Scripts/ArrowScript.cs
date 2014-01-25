using UnityEngine;
using System.Collections;

public class ArrowScript : MonoBehaviour {

	public float shootSpeed = 5.0F;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float move = Time.deltaTime * shootSpeed;
		this.transform.Translate (0, move, 0);
	}

	void OnCollisionEnter(Collision collision) {
		string tag = collision.gameObject.tag;
		if (tag == "Neutral") {
			Debug.Log("COLLISION with: " +  collision.gameObject.tag);
			Destroy(this.gameObject);
		}

	}
}
