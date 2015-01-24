using UnityEngine;
using System.Collections;

public class PlayerCollision : ActorCollision {

	public delegate void CollisionDelegate(ItemBase item);
	public CollisionDelegate itemCollision;

	public void OnCollisionEnter(Collision collision)
	{
		base.OnCollisionEnter (collision);
	}

	public void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.tag == Tags.ITEM) 
		{
			if (itemCollision != null)
			{
				itemCollision(collider.gameObject.GetComponent<ItemBase>());
			}
		}
	}
}
