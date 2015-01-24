using UnityEngine;
using System.Collections;

public class CreepController : MonoBehaviour {

	public delegate void MovementDelegateWithValue(float value);

	public MovementDelegateWithValue moveHorizontal;
	
	void Update() {
		moveHorizontal(0.1f);
	}
}
