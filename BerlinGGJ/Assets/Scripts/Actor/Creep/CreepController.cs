using UnityEngine;
using System.Collections;

public class CreepController : ActorController {

	[SerializeField]
	float horizontalMovement = 0f;

	public delegate void MovementDelegateWithValue(float value);

	public MovementDelegateWithValue moveHorizontal;

	void Start()
	{
		base.Start ();
	}

	void Update() {
		moveHorizontal(horizontalMovement);
	}

	void Die()
	{
		base.Die ();
	}
}
