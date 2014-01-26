using UnityEngine;
using System.Collections;

public class IsSwitchScript : MonoBehaviour {

	public string isSwitchFor;
	public bool on;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c) {
		if (!c.gameObject.name.Equals("wall") && !c.gameObject.tag.Equals( "Arrow"))  {
			// check if it's the player
			//Debug.Log("PRESSED SWITCH!");
			on = true;

			// only open the door if all the other switches for the same target are on
			foreach(GameObject switchObj in GameObject.FindGameObjectsWithTag("switch"))
			{
				if(switchObj.GetComponent<IsSwitchScript>().on == false)
				{
					Debug.Log("RETURNING");
					return;
				}
			}

		
			GameObject door = GameObject.Find(isSwitchFor);
			// door.remove renderer
			door.GetComponent<Renderer>().enabled = false;
			door.GetComponent<WallCollider>().enabled = false;
			door.GetComponent<BoxCollider>().enabled = false;
		}
	}

	void OnCollisionExit(Collision c) {
		on = false;
		// door.add material
		GameObject door = GameObject.Find(isSwitchFor);
		door.GetComponent<Renderer>().enabled = true;
		door.GetComponent<WallCollider>().enabled = true;
		door.GetComponent<BoxCollider>().enabled = true;
		Debug.Log("LEFT SWITCH!");
	}
}
