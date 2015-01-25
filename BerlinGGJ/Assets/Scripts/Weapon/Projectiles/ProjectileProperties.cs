using UnityEngine;
using System.Collections;

public class ProjectileProperties : MonoBehaviour {

	[SerializeField] private float _damage = 1.0f;
	public float damage
	{
		get{return _damage;}
	}


	void Update()
	{

		transform.Rotate(0,0,10);
	}
}
