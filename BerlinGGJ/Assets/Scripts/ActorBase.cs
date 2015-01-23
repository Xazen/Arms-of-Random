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
}
