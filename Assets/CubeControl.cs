using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour {
	Color32 _StartColor;
	Vector3 _StartRotation;
	Vector3 _StartScale;
	// Use this for initialization
	void Awake(){
		_StartRotation = transform.eulerAngles;
		_StartScale = transform.localScale;
		_StartColor = gameObject.GetComponent<Renderer> ().material.color;
	}

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ResetCube(){
		gameObject.GetComponent<Renderer> ().material.color = _StartColor;
		transform.eulerAngles = _StartRotation;
		transform.localScale = _StartScale;
	}

	public Vector3 GetInitialRotation(){
		return _StartRotation;
	}

	public Vector3 GetInitialScale(){
		return _StartScale;
	}

	public void SetRotation(string axis, float val){
		switch (axis) {
		case "x":
//			transform.Rotate(val,0,0);
			transform.eulerAngles = new Vector3(val, transform.eulerAngles.y, transform.eulerAngles.z);
			break;
		case "y":
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, val, transform.eulerAngles.z);
			break;
		case "z":
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, val);
			break;
		}
	}

	public void SetScale(string axis, float val){
		switch (axis) {
		case "x":
			transform.localScale = new Vector3(val, transform.localScale.y, transform.localScale.z);
			break;
		case "y":
			transform.localScale = new Vector3(transform.localScale.x, val, transform.localScale.z);
			break;
		case "z":
			transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, val);
			break;
		}
	}
}
