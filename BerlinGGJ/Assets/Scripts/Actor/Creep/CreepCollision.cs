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
		SoundManager.sharedManager.Play(SoundManager.sharedManager.playerLanding);
		//TODO implement
	}

	void OnCollisionEnter (Collision collision)
	{
		base.OnCollisionEnter (collision);
	}
}
