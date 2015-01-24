using UnityEngine;
using System.Collections;

public class ActorCollision : MonoBehaviour {

	public delegate void CollisionDelegate(ProjectileBase projectileBase);
	public CollisionDelegate projectileCollision;

	private bool onFloor;
	
	public void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == Tags.PROJECTILE)
		{
			if (projectileCollision != null)
			{
				ProjectileBase projectileBase = collision.gameObject.GetComponent<ProjectileBase>();
				projectileCollision(projectileBase);
			}
		}

		if(collision.gameObject.tag == Tags.FLOOR)
		{
			onFloor = true;
		}else{
			onFloor = false;
		}
	}

	public bool OnFloor()
	{
		Debug.Log (onFloor);
		return onFloor;
	}
}
