using UnityEngine;
using System.Collections;

public class CreepController : MonoBehaviour {

	[SerializeField]
	float horizontalMovement = 0f;

	public delegate void MovementDelegateWithValue(float value);

	public MovementDelegateWithValue moveHorizontal;

	void Update() {
		moveHorizontal(horizontalMovement);
	}
}
