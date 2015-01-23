using UnityEngine;
using System.Collections;

public class CreepCollision : MonoBehaviour {

	CreepBase _creepBase;

	void Awake()
	{
		_creepBase = GetComponent<CreepBase>();
	}

	void OnCollisionEnter(Collision collision)
	{
		if(Tags.PROJECTILE == collision.gameObject.tag){
			// TODO wait for dennis changes
//			_creepBase.ActorHealth.
		}
	}
}
