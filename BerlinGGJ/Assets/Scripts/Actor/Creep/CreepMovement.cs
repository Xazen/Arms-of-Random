using UnityEngine;
using System.Collections;

public class CreepMovement : MonoBehaviour {

	CreepBase _creepBase;
	private bool isMoving = false;
	[SerializeField] private float movementSpeed = 0.8f;
	private PlayerBase _playerBase;

	bool goingLeft = true;

	void Start() {
		_creepBase = GetComponent<CreepBase>();
		_creepBase.CreepController.moveHorizontal += OnMove;
		_playerBase = GameObject.FindGameObjectWithTag (Tags.PLAYER).GetComponent<PlayerBase> ();
	}

	void OnMove(float value)
	{
		if (!isMoving) {
			isMoving = true;
			if (gameObject.name == "Boss") {
				SoundManager.sharedManager.Play (SoundManager.sharedManager.bossWalk, true, SoundManager.BOSS);
			} else {

				SoundManager.sharedManager.Play (SoundManager.sharedManager.enemyWalk, true, SoundManager.ENEMY);

			}
		}
		Vector3 creepMoveDirection = (_playerBase.transform.position.x <= transform.position.x) ? Vector3.back : Vector3.forward;
		transform.Translate( creepMoveDirection * movementSpeed);

		if(creepMoveDirection == Vector3.forward)
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

	}

	public void StopMove()
	{
		if (isMoving) {
			isMoving = false;
			if (gameObject.name == "Boss") {
				SoundManager.sharedManager.Stop (SoundManager.BOSS);
			} else {
				SoundManager.sharedManager.Stop (SoundManager.ENEMY);
			}
		}

		_creepBase.CreepController.moveHorizontal -= OnMove;
	}
}
