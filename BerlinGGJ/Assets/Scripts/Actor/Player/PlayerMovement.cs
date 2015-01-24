using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] 
	private float _speed = 5.0f;

	[SerializeField]
	private float _jumpHeight = 500f;

	private PlayerBase _playerBase;

	public delegate void PositionChanged(Vector3 position);
	public event PositionChanged OnPositionChanged;


	bool inAir = false;
	bool secondJump = true;

	bool goingLeft = true;

	// Use this for initialization
	void Start () 
	{
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerInput.jumpDown += OnJumpDown;
		_playerBase.PlayerInput.jumpUp += OnJumpUp;
		_playerBase.PlayerInput.moveHorizontal += OnMove;
	}

	void Update(){
		if(_playerBase.ActorCollision.OnFloor())
		{
			inAir = false;
		}else{
			inAir = true;
		}
	}

	void OnJumpDown ()
	{
		if(!inAir){
			jump ();
			secondJump = true;
		}
		if(inAir && secondJump)
		{
			jump();
			secondJump = false;
		}
	}

	void jump ()
	{
		transform.rigidbody.AddForce (Vector3.up * _jumpHeight);
	}

	void OnMove(float value)
	{
		Vector3 newPosition = transform.position;
		newPosition.x += _speed * Time.deltaTime * value;
		transform.position = newPosition;

		if(value<0)
		{
			if(goingLeft)
			{
				transform.Rotate(0,180,0);
			}
			goingLeft = false;
		}else {

			if(!goingLeft)
			{
				transform.Rotate(0,180,0);
			}
			goingLeft = true;
		}

		if (OnPositionChanged != null)
		{
			OnPositionChanged(newPosition);
		}
	}
}
