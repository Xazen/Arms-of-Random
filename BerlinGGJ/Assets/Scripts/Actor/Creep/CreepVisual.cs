using UnityEngine;
using System.Collections;

public class CreepVisual : ActorVisual {

	
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
		if (newValue <= 0) 
		{
			if (gameObject.name == "Boss") {
				SoundManager.sharedManager.Play (SoundManager.sharedManager.bossDeath, false, SoundManager.BOSS);
			} else {

				SoundManager.sharedManager.Play(SoundManager.sharedManager.enemyDeath, false, SoundManager.ENEMY);
			}
			_animator.Play("death");
			_actorBase.GetComponent<CreepMovement>().StopMove();
			_actorBase.GetComponent<BoxCollider>().enabled = false;
			_actorBase.GetComponent<ParticleSystem>().Stop();
		}
	}

}
