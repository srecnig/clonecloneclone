#pragma strict

function Start () {

}

function Update () {
if (Input.GetKeyDown(KeyCode.W)) {
		transform.Translate(0,1,0);
	}
	if (Input.GetKeyDown(KeyCode.A)) {
		transform.Rotate(0,0,90);
	}
	if (Input.GetKeyDown(KeyCode.S)) {
		transform.Translate(0,-1,0);
	}
	if (Input.GetKeyDown(KeyCode.D)) {
		transform.Rotate(0,0,-90);
	}
}