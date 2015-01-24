using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

	[SerializeField] GameObject[] spawnObjects;
	[SerializeField] Transform spawnPoint;
	bool activated = false;

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == Tags.PLAYER)
		{
			if (!activated)
			{
				for(int i = 0; i < spawnObjects.Length; i++)
				{
					Vector3 actualSpawnPoint = spawnPoint.position;
					actualSpawnPoint.x += 5*i;
					Instantiate((GameObject)spawnObjects[i], actualSpawnPoint, ((GameObject)spawnObjects[i]).transform.rotation);
				}
			}
			activated = true;
		}
	}
}
