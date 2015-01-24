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

	private CreepController _creepController;
	
	public CreepController CreepController
	{
		get
		{
			if (_creepController == null)
			{
				_creepController = GetComponent<CreepController>();
			}
			
			return _creepController;
		}
	}

	private CreepVisual _creepVisual;
	
	public CreepVisual CreepVisual
	{
		get
		{
			if (_creepVisual == null)
			{
				_creepVisual = GetComponent<CreepVisual>();
			}
			
			return _creepVisual;
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

}
