using UnityEngine;
using System.Collections;

public class CreepCollision : MonoBehaviour {

	CreepBase creepBase;

	void Awake()
	{
	}

	void OnCollisionEnter(Collision collision)
	{
		if(Tags.PROJECTILE == collision.gameObject.tag){

		}
	}
}
