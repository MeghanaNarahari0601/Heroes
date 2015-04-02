#pragma strict
function Update() {
    var v = Input.GetAxis("Vertical");
    if(Mathf.Abs(v) > 0.1f) {
        GetComponent.<Animation>()["Walk"].speed = v;
        GetComponent.<Animation>().CrossFade("Walk");
        transform.position.z += v;
    }
    else GetComponent.<Animation>().CrossFade("Idle");
}