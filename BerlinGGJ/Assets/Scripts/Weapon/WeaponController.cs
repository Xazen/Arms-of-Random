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
		if (Input.GetKeyDown (KeyCode.Space))
		{
			attack(Random.Range(0,3));
		}
	}

	public void OnAttack(ItemBase itemBase)
	{
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
		Debug.Log (n);
		switch (n) {
		case 0:
			GameObject projectile = (GameObject) Instantiate(_projectile, transform.position, Quaternion.identity);
			projectile.transform.constantForce.force = Vector3.right * 100;
			projectile.transform.Translate( Vector3.forward );
			break;
		case 1:
			GameObject.Find("muzzle/fire_spray").GetComponent<ParticleSystem>().Play(); 
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
