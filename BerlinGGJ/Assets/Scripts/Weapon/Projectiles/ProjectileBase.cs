using UnityEngine;
using System.Collections;

public class ProjectileBase : MonoBehaviour {

	private ProjectileProperties _projectileProperties;
	public ProjectileProperties ProjectileProperties
	{
		get 
		{
			if (_projectileProperties == null)
			{
				_projectileProperties = GetComponent<ProjectileProperties>();
			}
			return _projectileProperties;
		}
	}
}
