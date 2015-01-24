using UnityEngine;
using System.Collections;

public class GrassGenerator : MonoBehaviour {



	[SerializeField]
	float _grassDensityAmount = 20;


	// Use this for initialization
	void Start () {
		Object o  = Resources.Load("Grass/foilage1");
		Debug.Log("");

				for (int i = 0; i < _grassDensityAmount; i++) {
	
				}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
