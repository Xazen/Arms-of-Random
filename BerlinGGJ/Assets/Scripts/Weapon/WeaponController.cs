using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	[SerializeField] private GameObject _projectile;
	PlayerBase _playerBase;

	void Start () {
		_playerBase = GameObject.FindGameObjectWithTag(Tags.PLAYER).GetComponent<PlayerBase>();
	}
	
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Z))
		{
			attack(0);
		}
		if (Input.GetKeyDown (KeyCode.X))
		{
			attack(1);
		}
		if (Input.GetKeyDown (KeyCode.C))
		{
			attack(2);
		}
		if (Input.GetKeyDown (KeyCode.V))
		{
			attack(3);
		}
//		if (Input.GetKeyDown (KeyCode.B))
//		{
//			attack(4);
//		}
	}

	public void OnAttack(int weaponType)
	{
		attack (weaponType);

	}


	void attack(int n)
	{
		GameObject projectile;
		switch (n) {
		// shot
		case 0:
			projectile = (GameObject) Instantiate(_projectile, GameObject.Find("muzzle").transform.position, Quaternion.identity);
			projectile.transform.constantForce.force = Vector3.right * 100;
			projectile.transform.Translate( Vector3.forward );
			break;
		// throw
		case 1:
			projectile = (GameObject) Instantiate(_projectile, GameObject.Find("muzzle").transform.position, Quaternion.identity);
			projectile.transform.constantForce.force = Vector3.right * 50 + Vector3.up * 20;
			projectile.transform.Translate( Vector3.forward );
			break;
		// flame thrower
		case 2:
			GameObject.Find("muzzle/fire_spray").GetComponent<ParticleSystem>().Play(); 
			break;
		// rocket launcher
		case 3:
			GameObject.Find("muzzle/rocket_launcher").GetComponent<ParticleSystem>().Play(); 
			break;
		default:
			break;
		}
	}

	public static int RandomWeaponType()
	{
		return Random.Range (0, 4);
	}
}
