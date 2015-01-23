using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public delegate void InputDelegate();
	public delegate void InputDelegateWithValue(float value);

	#pragma warning disable
	private PlayerBase _playerBase;

	public InputDelegate jump;
	public InputDelegateWithValue moveHorizontal;
	public InputDelegateWithValue moveVertical;

	// Use this for initialization
	void Start () {
		_playerBase = GetComponent<PlayerBase> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) 
		{
			jump();
		}

		if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.0f) 
		{
			moveHorizontal(Input.GetAxis("Horizontal"));
		}

		if (Mathf.Abs(Input.GetAxis("Vertical")) > 0.0f) 
		{
			moveVertical(Input.GetAxis("Vertical"));
		}
	}
}
