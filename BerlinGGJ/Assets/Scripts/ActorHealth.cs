using UnityEngine;
using System.Collections;

public class ActorHealth : MonoBehaviour {
	
	[SerializeField]
	float _initialHP = 1f;

	[SerializeField]
	float _hp = 10f;


	public void decreaseHP(float amount)
	{
		if((_hp - amount) < 0 )
		{
			die ();
		}
	}

	public void resteHP()
	{
		_hp = _initialHP;
	}

	public void die()
	{
		// TODO implement
	}

	
}
