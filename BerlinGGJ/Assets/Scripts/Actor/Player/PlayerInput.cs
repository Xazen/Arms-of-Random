using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public delegate void InputDelegate();
	public delegate void InputDelegateWithValue(float value);
	public delegate void InputDelegateWithInteger (int value);

	#pragma warning disable
	private PlayerBase _playerBase;

	public InputDelegate jumpDown;
	public InputDelegate jumpUp;
	public InputDelegateWithInteger attack;
	public InputDelegateWithValue moveHorizontal;
	public InputDelegate stopMoveHorizontal;
	public InputDelegate startMoveHorizontal;
	public InputDelegateWithValue moveVertical;
	public InputDelegateWithInteger number;

	private bool isHorizontal = false;

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
			if (jumpDown != null) 
			{
				jumpDown();
			}
		}

		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0.0f) {

			if (!isHorizontal)
			{
				isHorizontal = true;
				if (startMoveHorizontal != null)
				{
					startMoveHorizontal();
				}
			}

			if (moveHorizontal != null) {
					moveHorizontal (Input.GetAxis ("Horizontal"));
			}
		} else {
			if (isHorizontal)
			{
				isHorizontal = false;
				if (stopMoveHorizontal != null)
				{
					stopMoveHorizontal();
				}
			}
		}


		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0.0f) 
		{
			if (moveVertical != null) 
			{
				moveVertical (Input.GetAxis ("Vertical"));
			}
		}
	}
}
