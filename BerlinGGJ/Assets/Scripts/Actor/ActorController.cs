using UnityEngine;
using System.Collections;

public class ActorController : MonoBehaviour {

	private ActorBase _actorBase;

	public void Start()
	{
		_actorBase = GetComponent<ActorBase> ();
		_actorBase.ActorHealth.OnHealthChanged += OnHealthChanged;
	}

	public void OnHealthChanged(float oldValue, float newValue)
	{
		if (newValue <= 0) 
		{
			Die();
		}
	}

	public void Die()
	{
		Destroy (this.gameObject);
	}
}
