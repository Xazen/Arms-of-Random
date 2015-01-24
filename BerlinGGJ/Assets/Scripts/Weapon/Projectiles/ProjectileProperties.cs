using UnityEngine;
using System.Collections;

public class ProjectileProperties : MonoBehaviour {

	[SerializeField] private float _damage = 1.0f;
	public float damage
	{
		get{return _damage;}
	}
}
