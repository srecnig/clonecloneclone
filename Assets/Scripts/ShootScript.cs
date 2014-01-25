using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {

	public Transform playerTransform;

	// Use this for initialization
	void Start () {
		this.playerTransform = GameObject.Find ("clone").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			// instantiate arrow prefab
			GameObject arrow = Instantiate(Resources.Load("Arrow")) as GameObject; 
			arrow.transform.position = playerTransform.position;
			arrow.AddComponent("ArrowScript");
		}
	}
}
