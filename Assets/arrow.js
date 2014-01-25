#pragma strict

function Start () {
	
}

function Update () {
	if (Input.GetKeyDown(KeyCode.Space)) {
		Instantiate(GameObject.Find("Arrow"), GameObject.Find("Clone").transform.position, GameObject.Find("Clone").transform.rotation);
	}
	transform.Translate(0,0.5,0);
}