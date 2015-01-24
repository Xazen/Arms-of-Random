using UnityEngine;
using System.Collections;

public class ActorController : MonoBehaviour {

	private ActorBase _actorBase;

	void Start()
	{
		_actorBase = GetComponent<ActorBase> ();
		_actorBase.ActorHealth.OnHealthChanged += OnHealthChanged;
	}

	void OnHealthChanged(float oldValue, float newValue)
	{
		if (newValue <= 0) 
		{
			Die();
		}
	}

	void Die()
	{
		Destroy (this.gameObject);
	}
}
