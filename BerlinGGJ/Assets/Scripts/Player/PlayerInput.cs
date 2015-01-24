using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public delegate void InputDelegate();
	public delegate void InputDelegateWithValue(float value);
	public delegate void InputDelegateWithInteger (int value);

	#pragma warning disable
	private PlayerBase _playerBase;

	public InputDelegate jump;
	public InputDelegateWithInteger attack;
	public InputDelegateWithValue moveHorizontal;
	public InputDelegateWithValue moveVertical;
	public InputDelegateWithInteger number;

	// Use this for initialization
	void Start () {
		_playerBase = GetComponent<PlayerBase> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Alpha1) || Input.GetKeyDown (KeyCode.Keypad1)) 
		{
			number(1);
		}

		if (Input.GetKeyDown (KeyCode.Alpha2) || Input.GetKeyDown (KeyCode.Keypad2)) 
		{
			number(2);
		}

		if (Input.GetKeyDown (KeyCode.Alpha3) || Input.GetKeyDown (KeyCode.Keypad3)) 
		{
			number(3);
		}

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
				attack(101);
			}
		}
	}
}
