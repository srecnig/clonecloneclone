using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {

	public Transform cloneTransform;

	// Use this for initialization
	void Start () {
		this.cloneTransform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			// Debug.Log("SHOOT!" + this.gameObject.tag);
			// instantiate arrow prefab
			GameObject animation = Instantiate(Resources.Load("arrow_animation_0")) as GameObject;
			GameObject arrow = Instantiate(Resources.Load("Arrow")) as GameObject; 
			Vector3 pos = this.cloneTransform.position;
			animation.transform.position = pos;
			animation.transform.rotation = this.cloneTransform.rotation;
			animation.transform.Rotate(0,0,90);
			animation.transform.Translate(-1,0.5f,-0.3f);
			arrow.transform.position = pos;
			arrow.transform.rotation = this.cloneTransform.rotation;
			arrow.transform.Translate (0, 0.8F, 0);
			arrow.AddComponent("ArrowScript");

		}
	}
}
