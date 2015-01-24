using UnityEngine;
using System.Collections;

public class ActorCollision : MonoBehaviour {

	public delegate void CollisionDelegate(ProjectileBase projectileBase);
	public CollisionDelegate projectileCollision;
	
	public void OnCollisionEnter (Collision collision)
	{
		if (this.gameObject.tag == Tags.PLAYER) {
			Debug.Log ("actorcollision called in player");
				}
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
