using UnityEngine;
using System.Collections;

public class CreepMovement : MonoBehaviour {

	CreepBase _creepBase;

	void Start() {
		_creepBase = GetComponent<CreepBase>();
	}

	void Update () {
		transform.Translate( Vector3.forward * 0.1f);
	}
}
