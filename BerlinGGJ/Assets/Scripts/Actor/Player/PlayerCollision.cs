using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	public delegate void CollisionDelegate(ItemBase item);
	public CollisionDelegate itemCollision;

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == Tags.ITEM) 
		{
			if (itemCollision != null)
			{
				itemCollision(collision.gameObject.GetComponent<ItemBase>());
			}
		}
	}
}
