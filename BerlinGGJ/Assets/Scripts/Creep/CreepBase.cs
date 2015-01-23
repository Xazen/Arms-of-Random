using UnityEngine;
using System.Collections;

public class CreepBase : ActorBase {

	private CreepMovement _creepMovement;

	public CreepMovement CreepMovement
	{
		get
		{
			if (_creepMovement == null)
			{
				_creepMovement = GetComponent<CreepMovement>();
			}
			
			return _creepMovement;
		}
	}

	private CreepCollision _creepCollision;

	public CreepCollision CreepCollision
	{
		get
		{
			if (_creepCollision == null)
			{
				_creepCollision = GetComponent<CreepCollision>();
			}
			
			return _creepCollision;
		}
	}

	private ActorHealth _actorHealth;

	public ActorHealth ActorHealth
	{
		get
		{
			if (_actorHealth == null)
			{
				_actorHealth = GetComponent<ActorHealth>();
			}
			
			return _actorHealth;
		}
	}
}
