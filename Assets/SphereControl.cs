using UnityEngine;
using System.Collections;

public class SphereControl : MonoBehaviour {

	Vector3 _StartPosition;

	// Use this for initialization
	void Start () {
		_StartPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DropSphere(){
		GetComponent<Rigidbody> ().isKinematic = false;
	}

	public void ResetSphere(){
		GetComponent<Rigidbody> ().isKinematic = true;
		transform.position = _StartPosition;
	}
}
