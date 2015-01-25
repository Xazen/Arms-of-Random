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
			Destroy ( collision.gameObject );
			
		}

		if(collision.gameObject.tag == Tags.FLOOR)
		{
			if(gameObject.tag == Tags.PLAYER)
			{
				SoundManager.sharedManager.Play(SoundManager.sharedManager.playerLanding);
			}
			onFloor = true;
		}else{
			onFloor = false;
		}
	}

	public bool OnFloor()
	{
		return onFloor;
	}
}
