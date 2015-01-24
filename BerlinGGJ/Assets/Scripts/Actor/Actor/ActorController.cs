using UnityEngine;
using System.Collections;

public class ActorController : MonoBehaviour {

	private ActorBase _actorBase;

	public void Start()
	{
		_actorBase = GetComponent<ActorBase> ();
	}


	public void Die()
	{
		Destroy (this.gameObject);
	}
}
