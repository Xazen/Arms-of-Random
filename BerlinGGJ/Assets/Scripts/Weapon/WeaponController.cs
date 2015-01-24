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
		if (Input.GetKeyDown (KeyCode.S))
		{
			attack(3);
		}
	}

	public void OnAttack(ItemBase itemBase)
	{

		// TODO implement correctly ...
//				switch (itemBase.ItemProperty.WeaponType) {
//				case 0:
//					GameObject projectile = (GameObject) Instantiate(_projectile, transform.position, Quaternion.identity);
//					projectile.transform.constantForce.force = Vector3.right * 100;
//					projectile.transform.Translate( Vector3.forward );
//					break;
//
//				default:
//					break;
//				}

	}


	void attack(int n)
	{
		GameObject projectile;
		switch (n) {
		// shot
		case 0:
			projectile = (GameObject) Instantiate(_projectile, transform.position + Vector3.right, Quaternion.identity);
			projectile.transform.constantForce.force = Vector3.right * 100;
			projectile.transform.Translate( Vector3.forward );
			break;
		// throw
		case 1:
			projectile = (GameObject) Instantiate(_projectile, transform.position + Vector3.right, Quaternion.identity);
			projectile.transform.constantForce.force = Vector3.right * 100 + Vector3.up * 100;
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
		return Random.Range (0, 12);
	}
}
