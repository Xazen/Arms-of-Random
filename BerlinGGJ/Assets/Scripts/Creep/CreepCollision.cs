using UnityEngine;
using System.Collections;

public class CreepCollision : MonoBehaviour {

	private CreepBase _creepBase;

	void Awake()
	{
		_creepBase = GetComponent<CreepBase> ();
	}

	void OnCollisionEnter(Collision collision)
	{
		if(Tags.PROJECTILE == collision.gameObject.tag){
		}
	}
}
