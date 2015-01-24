using UnityEngine;
using System.Collections;

public class ActorHealth : MonoBehaviour {
	
	[SerializeField]
	float _initialHP = 10f;

	[SerializeField]
	float _hp = 10f;

	bool died = false;

	public delegate void HealthChanged(float oldValue, float newValue);
	public event HealthChanged OnHealthChanged;

	public void decreaseHP(float amount)
	{
		if (_hp > 0.0f) 
		{
			float oldHp = _hp;
			_hp -= amount;
			if (OnHealthChanged != null) 
			{
				OnHealthChanged (oldHp, _hp);
			}
		}

		if((_hp - amount) < 0 && !died)
		{
			died = true;
			die ();
		}
	}

	public void resetHP()
	{
		float oldHp = _hp;
		_hp = _initialHP;
		if (OnHealthChanged != null) 
		{
			OnHealthChanged (oldHp, _hp);
		}
		died = false;
	}

	public void die()
	{
	
	}

	
}
