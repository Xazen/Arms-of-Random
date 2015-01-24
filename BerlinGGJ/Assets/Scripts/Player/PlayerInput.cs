using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public delegate void InputDelegate();
	public delegate void InputDelegateWithValue(float value);

	#pragma warning disable
	private PlayerBase _playerBase;

	public InputDelegate jump;
	public InputDelegate attack;
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
			if (jump != null) 
			{
				jump();
			}
		}

		if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.0f) 
		{
			if (moveHorizontal != null)
			{
				moveHorizontal(Input.GetAxis("Horizontal"));
			}
		}

		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.0f) 
		{
			if (moveVertical != null) 
			{
				moveVertical (Input.GetAxis ("Vertical"));
			}
		}

		if (Input.GetButtonDown ("Fire1")) 
		{
			if (attack != null) 
			{
				attack();
			}
		}
	}
}
