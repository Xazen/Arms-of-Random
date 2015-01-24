using UnityEngine;
using System.Collections;

public class ActorBase : MonoBehaviour {

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

	private ActorCollision _actorCollision;
	public ActorCollision ActorCollision
	{
		get
		{
			if (_actorCollision == null)
			{
				_actorCollision = GetComponent<ActorCollision>();
			}
			return _actorCollision;
		}
	}

	private ActorController _actorController;
	public ActorController ActorController
	{
		get
		{
			if (_actorController == null)
			{
				_actorController = GetComponent<ActorController>();
			}
			return _actorController;
		}
	}
	
}
