using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	[SerializeField]
	private InputField _InputField_RotationX = null;
	[SerializeField]
	private InputField _InputField_RotationY = null;
	[SerializeField]
	private InputField _InputField_RotationZ = null;
	[SerializeField]
	private InputField _InputField_ScaleX = null;
	[SerializeField]
	private InputField _InputField_ScaleY = null;
	[SerializeField]
	private InputField _InputField_ScaleZ = null;

	// Use this for initialization
	void Start () {
		InputField.SubmitEvent submitEvent = new InputField.SubmitEvent ();
		submitEvent.AddListener (GetRotationX);
		_InputField_RotationX.onEndEdit = submitEvent;

		submitEvent = new InputField.SubmitEvent ();
		submitEvent.AddListener (GetRotationY);
		_InputField_RotationY.onEndEdit = submitEvent;

		submitEvent = new InputField.SubmitEvent ();
		submitEvent.AddListener (GetRotationZ);
		_InputField_RotationZ.onEndEdit = submitEvent;

		submitEvent = new InputField.SubmitEvent ();
		submitEvent.AddListener (GetScaleX);
		_InputField_ScaleX.onEndEdit = submitEvent;

		submitEvent = new InputField.SubmitEvent ();
		submitEvent.AddListener (GetScaleY);
		_InputField_ScaleY.onEndEdit = submitEvent;

		submitEvent = new InputField.SubmitEvent ();
		submitEvent.AddListener (GetScaleZ);
		_InputField_ScaleZ.onEndEdit = submitEvent;

		Invoke ("SetOriginalValues", 2);
		SetOriginalValues ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SetOriginalValues(){
		Vector3 initialRotation = GameObject.Find ("Cube").GetComponent<CubeControl> ().GetInitialRotation ();
		Vector3 initialScale = GameObject.Find ("Cube").GetComponent<CubeControl> ().GetInitialScale ();
//		_InputField_RotationX.transform.FindChild ("Text").GetComponent<Text> ().text = ""+initialRotation.x;
		_InputField_RotationX.text = ""+initialRotation.x;
		_InputField_RotationY.text = ""+initialRotation.y;
		_InputField_RotationZ.text = ""+initialRotation.z;
		_InputField_ScaleX.text = ""+initialScale.x;
		_InputField_ScaleY.text = ""+initialScale.y;
		_InputField_ScaleZ.text = ""+initialScale.z;
	}


	public void OnPlay(){
		GameObject.Find ("Sphere").GetComponent<SphereControl> ().DropSphere ();
	}

	public void OnReset(){
		GameObject.Find ("Sphere").GetComponent<SphereControl> ().ResetSphere ();
		GameObject.Find ("Cube").GetComponent<CubeControl> ().ResetCube ();
		SetOriginalValues ();
	}

	void GetRotationX(string val){
		Debug.Log ("RotationX : "+ System.Convert.ToDecimal(val));
		GameObject.Find ("Cube").GetComponent<CubeControl> ().SetRotation ("x", (float)System.Convert.ToDecimal(val));
	}

	void GetRotationY(string val){
		Debug.Log ("RotationY : "+ System.Convert.ToDecimal(val));
		GameObject.Find ("Cube").GetComponent<CubeControl> ().SetRotation ("y", (float)System.Convert.ToDecimal(val));
	}

	void GetRotationZ(string val){
		Debug.Log ("RotationZ : "+ System.Convert.ToDecimal(val));
		GameObject.Find ("Cube").GetComponent<CubeControl> ().SetRotation ("z", (float)System.Convert.ToDecimal(val));
	}

	void GetScaleX(string val){
		Debug.Log ("ScaleX : "+ System.Convert.ToDecimal(val));
		GameObject.Find ("Cube").GetComponent<CubeControl> ().SetScale ("x", (float)System.Convert.ToDecimal(val));
	}

	void GetScaleY(string val){
		Debug.Log ("ScaleY : "+ System.Convert.ToDecimal(val));
		GameObject.Find ("Cube").GetComponent<CubeControl> ().SetScale ("y", (float)System.Convert.ToDecimal(val));
	}

	void GetScaleZ(string val){
		Debug.Log ("ScaleZ : "+ System.Convert.ToDecimal(val));
		GameObject.Find ("Cube").GetComponent<CubeControl> ().SetScale ("z", (float)System.Convert.ToDecimal(val));
	}
}
