using UnityEngine;
using System.Collections;

public class ActorCollision : MonoBehaviour {

	public delegate void CollisionDelegate(ProjectileBase projectileBase);
	public CollisionDelegate projectileCollision;
	
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
	}
}
