using UnityEngine;
using System.Collections;

public class ActorHealth : MonoBehaviour {
	
	[SerializeField]
	float _initialHP = 10f;

	[SerializeField]
	float _hp = 10f;

	bool died = false;

	protected ActorBase _actorBase;

	public delegate void HealthChanged(float oldValue, float newValue);
	public event HealthChanged OnHealthChanged;

	protected void Start()
	{
		_actorBase = GetComponent<ActorBase> ();
		_actorBase.ActorCollision.projectileCollision += OnProjectileCollision;
	}

	public void decreaseHP(float amount)
	{
		if (_hp > 0.0f) 
		{
			float oldHp = _hp;
			_hp -= amount;
			if (OnHealthChanged != null) 
			{
				OnHealthChanged (oldHp, _hp);
			}
		}

		if((_hp - amount) < 0 && !died)
		{
			died = true;
			die ();
		}
	}

	public bool isDead()
	{
		return died;
	}

	public void resetHP()
	{
		float oldHp = _hp;
		_hp = _initialHP;
		if (OnHealthChanged != null) 
		{
			OnHealthChanged (oldHp, _hp);
		}
		died = false;
	}

	public int HP()
	{
		return (int) _hp;
	}

	public int InitialHP()
	{
		return (int) _initialHP;
	}

	public void die()
	{

	}

	public void OnProjectileCollision(ProjectileBase projectileBase)
	{
		decreaseHP (projectileBase.ProjectileProperties.damage);
	}

	void OnParticleCollision (GameObject gameObject ){
		GameObject.FindWithTag(Tags.CAMERAHOLDER).GetComponent<CameraRumbler>().rumble(0.1f, 0.2f);
		decreaseHP (5);
		Destroy(gameObject);
	}
}
