using UnityEngine;
using System.Collections;

public class PlayerVisual : ActorVisual {
	ActorBase _actorBase;
	Animator _animator;
	
	public void Start()
	{
		_actorBase = GetComponent<ActorBase> ();
		_actorBase.ActorHealth.OnHealthChanged += OnHealthChanged;
		_animator = _actorBase.GetComponent<Animator>();
	}
	
	public void OnHealthChanged(float oldValue, float newValue)
	{
		Debug.Log("health ...");
		if (newValue <= 0) 
		{
			_animator.Play("death");
			_actorBase.GetComponent<PlayerInput>().enabled = false;
		}
	}
}
