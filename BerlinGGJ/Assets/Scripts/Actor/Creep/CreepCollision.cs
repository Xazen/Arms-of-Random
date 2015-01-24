using UnityEngine;
using System.Collections;

public class CreepCollision : MonoBehaviour {
	
	CreepBase _creepBase;

	void Awake()
	{
		_creepBase = GetComponent<CreepBase>();
	}

	void OnParticleCollision (GameObject gameObject )
	{
		//TODO implement
	}
}
