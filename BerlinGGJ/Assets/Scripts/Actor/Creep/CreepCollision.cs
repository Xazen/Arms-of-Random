using UnityEngine;
using System.Collections;

public class CreepCollision : ActorCollision {
	
	CreepBase _creepBase;

	void Awake()
	{
		_creepBase = GetComponent<CreepBase>();
	}

	void OnParticleCollision (GameObject gameObject )
	{
		//TODO implement
	}

	void OnCollisionEnter (Collision collision)
	{
		base.OnCollisionEnter (collision);
	}
}
