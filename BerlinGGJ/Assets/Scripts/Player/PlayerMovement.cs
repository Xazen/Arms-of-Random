using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] private float _speed;
	private PlayerBase _playerBase;

	// Use this for initialization
	void Start () 
	{
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerInput.jump += OnJump;
		_playerBase.PlayerInput.moveHorizontal += OnMove;
		_playerBase.PlayerInput.moveVertical += OnVMove;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnJump ()
	{
		_playerBase.ActorHealth.decreaseHP (1.0f);
	}

	void OnMove(float value)
	{
		_playerBase.ActorHealth.resetHP();
	}

	void OnVMove(float value)
	{

	}
}
