using UnityEngine;
using System.Collections;

public class PlayerHealth : ActorHealth {

	void OnCollisionEnter(Collision collision)
	{
		decreaseHP (1);
	}


}
