using UnityEngine;
using System.Collections;

public class PlayerCollision : ActorCollision {

	public delegate void CollisionDelegate(ItemBase item);
	public CollisionDelegate itemCollision;

	public void OnCollisionEnter(Collision collision)
	{
		base.OnCollisionEnter (collision);
		if (collision.gameObject.tag == Tags.ITEM) 
		{
			if (itemCollision != null)
			{
				itemCollision(collision.gameObject.GetComponent<ItemBase>());
			}
		}
	}
}
