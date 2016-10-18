using UnityEngine;
using System.Collections;

public class spawnMany : MonoBehaviour {

	//THIS IS A WAY TO SPAWN A BIG SET NUMBER OF OBJECTS

	public Transform thingToSpawn;

	public int numToSpawn = 1000;

	GameObject[] storedSpawns;

	//insideunitsphere and on unit sphere alters the spawn shape in a spherical manner

	// Use this for initialization
	void Start () {
		GameObject[] storedSpawns = new GameObject[numToSpawn];
		for (int i = 0; i < storedSpawns.Length; i++) {
			storedSpawns [i] = Instantiate (thingToSpawn, Random.insideUnitSphere * 30, Quaternion.identity) as GameObject;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
