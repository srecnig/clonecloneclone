using UnityEngine;
using System.Collections;

public class destroy_animation : MonoBehaviour {
	private float sek;
	// Use this for initialization
	void Start () {
		sek = 0.8f;
	}
	
	// Update is called once per frame
	void Update () {
		if (sek<=0){
			Destroy (this.gameObject);
		} else {sek=sek-1*Time.deltaTime;}
	}
}
