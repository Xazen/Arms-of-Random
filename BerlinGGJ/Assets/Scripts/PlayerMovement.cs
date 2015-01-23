using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private PlayerBase _playerBase;

	// Use this for initialization
	void Start () {
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerInput.jump += OnJump;
		_playerBase.PlayerInput.right += OnRight;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnJump ()
	{

	}

	void OnRight()
	{

	}
}
