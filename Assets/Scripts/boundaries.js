#pragma strict

function Start () {

}

function Update () {
	if (transform.position.y > 10) {
			transform.position.y = 9.5;
		}
	if (transform.position.y < 0) {
			transform.position.y = 0.5;
		}
	if (transform.position.x > 10) {
			transform.position.x = 9.5;
		}
	if (transform.position.x < 0) {
			transform.position.x = 0.5;
		}
}