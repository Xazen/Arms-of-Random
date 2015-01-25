using UnityEngine;
using System.Collections;

public class CreepMovement : MonoBehaviour {

	CreepBase _creepBase;
	private bool isMoving = false;

	void Start() {
		_creepBase = GetComponent<CreepBase>();
		_creepBase.CreepController.moveHorizontal += OnMove;
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
		transform.Translate( Vector3.back * value);
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
