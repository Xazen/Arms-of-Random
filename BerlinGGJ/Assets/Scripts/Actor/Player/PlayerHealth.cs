using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : ActorHealth {

	Image healthBar;

	void Start()
	{
		base.Start();
		healthBar = GameObject.FindWithTag(Tags.HEALTHBAR).GetComponent<Image>();
	}



	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == Tags.PROJECTILE || collision.gameObject.tag == Tags.CREEP)
		{
			decreaseHP (1);
			healthBar.fillAmount = HP() * 0.1f;
		}
	}

}
