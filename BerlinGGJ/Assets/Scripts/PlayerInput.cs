using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	delegate void InputDelegate();
	private PlayerBase _playerBase;
	public InputDelegate jump;
	public InputDelegate right;
	public InputDelegate left;

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

		if (Input.GetButtonDown ("Right")) 
		{
			right();
		}

		if (Input.GetButtonDown ("Left")) 
		{
			left();
		}
	}
}
