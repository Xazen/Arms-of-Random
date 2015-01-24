using UnityEngine;
using System.Collections;

public class CreepMovement : MonoBehaviour {

	CreepBase _creepBase;

	void Start() {
		_creepBase = GetComponent<CreepBase>();
		_creepBase.CreepController.moveHorizontal += OnMove;
	}

	void OnMove(float value)
	{
		transform.Translate( Vector3.back * value);
	}

	public void StopMove()
	{
		_creepBase.CreepController.moveHorizontal -= OnMove;
	}
}
