using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] private float _speed = 5.0f;
	private PlayerBase _playerBase;

	public delegate void PositionChanged(Vector3 position);
	public event PositionChanged OnPositionChanged;

	// Use this for initialization
	void Start () 
	{
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerInput.jump += OnJump;
		_playerBase.PlayerInput.moveHorizontal += OnMove;
	}

	void OnJump ()
	{
		
	}

	void OnMove(float value)
	{
		Vector3 newPosition = transform.position;
		newPosition.x += _speed * Time.deltaTime * value;
		transform.position = newPosition;

		if (OnPositionChanged != null)
		{
			OnPositionChanged(newPosition);
		}
	}
}
