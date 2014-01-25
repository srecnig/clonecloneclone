using UnityEngine;
using System.Collections;

public class ArrowScript : MonoBehaviour {

	public float shootSpeed = 15.0F;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float move = Time.deltaTime * shootSpeed;
		this.transform.Translate (0, move, 0);
		if (this.transform.position.y > 10 || this.transform.position.y < 0
		    || this.transform.position.x > 10 || this.transform.position.x < 0) {
			Destroy(this.gameObject);
		}
	}
}
